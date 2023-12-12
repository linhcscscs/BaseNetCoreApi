using BaseNetCoreApi.BackgroundTask;
using BaseNetCoreApi.DomainService;
using BaseNetCoreApi.Helper;
using BaseNetCoreApi.Infrastructure.CacheProvider;
using BaseNetCoreApi.Infrastructure.ContextProvider;
using BaseNetCoreApi.Infrastructure.Models.BO_GIAO_DUCEntities;
using BaseNetCoreApi.Infrastructure.Models.QUAN_LY_THU_PHIEntities;
using BaseNetCoreApi.Middleware;
using BaseNetCoreApi.Models.Entities;
using BaseNetCoreApi.Models.Model;
using BaseNetCoreApi.Service;
using BaseNetCoreApi.Services;
using BaseNetCoreApi.Values;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json.Serialization;
using System.IO.Compression;
using System.Reflection;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Logging.ClearProviders();
builder.Logging.AddConsole();
builder.Services.AddControllers(options =>
{
    options.RespectBrowserAcceptHeader = true;
})
    .AddNewtonsoftJson(options =>
    {
        options.SerializerSettings.ContractResolver = new DefaultContractResolver();
    });

#region Properties
const string QI_CORS = "QI_CORS";

IConfiguration config = new ConfigurationBuilder()
                          .SetBasePath(Directory.GetCurrentDirectory())
                          .AddJsonFile("appsettings.json", false, false)
                          .AddEnvironmentVariables()
                          .Build();
var services = builder.Services;
#endregion

#region CORS
var lstCors = config.GetSection("AppSettings:CORSUrls").GetChildren().Select(
        s => s.Value?.ToString()).ToArray() ?? new string[0];
if (lstCors.Count() > 0)
{
    services.AddCors(options =>
    {
        options.AddPolicy(name: QI_CORS,
                          policy =>
                          {
                              policy.WithOrigins(lstCors!)
                              .AllowAnyMethod()
                              .AllowCredentials()
                              .AllowAnyHeader();
                          });
    });
}
else
{
    if (builder.Environment.IsDevelopment())
    {
        services.AddCors(options =>
        {
            options.AddPolicy(name: QI_CORS,
                              policy =>
                              {
                                  policy.AllowAnyHeader();
                                  policy.AllowAnyMethod();
                                  policy.AllowAnyOrigin();
                                  policy.AllowCredentials();
                              });
        });
    }
    else
    {
        builder.Services.AddCors(options =>
        {
            options.AddPolicy(name: QI_CORS,
                              policy =>
                              {
                                  policy.AllowAnyHeader();
                                  policy.AllowAnyMethod();
                                  policy.AllowAnyOrigin();
                                  policy.AllowCredentials();
                              });
        });
    }
}
#endregion

#region Bindding Configure Helper
ConfigurationHelper.Configuration = config;
ConfigurationHelper.WebHostEnvironment = builder.Environment;
#endregion
#region DBContext
services.AddDbContext<BO_GIAO_DUCEntities>(options =>
                options.UseSqlServer(config.GetConnectionString("ConnectionStrings:BO_GIAO_DUCEntities")));
services.AddDbContext<QUAN_LY_THU_PHIEntities>(options =>
                options.UseSqlServer(config.GetConnectionString("ConnectionStrings:QUAN_LY_THU_PHIEntities")));
#endregion
#region JWT Authen
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
})

// Adding Jwt Bearer
.AddJwtBearer(options =>
{
    options.SaveToken = true;
    options.RequireHttpsMetadata = false;
    options.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ClockSkew = TimeSpan.Zero,

        ValidAudience = JWTSettings.ValidAudience,
        ValidIssuer = JWTSettings.ValidIssuer,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JWTSettings.Secret!))
    };
});

// Swagger JWT config
services.AddSwaggerGen(c =>
{
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = @"JWT Authorization header using the Bearer scheme. \r\n\r\n 
                      Enter 'Bearer' [space] and then your token in the text input below.
                      \r\n\r\nExample: 'Bearer 12345abcdef'",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer"
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement()
      {
        {
          new OpenApiSecurityScheme
          {
            Reference = new OpenApiReference
              {
                Type = ReferenceType.SecurityScheme,
                Id = "Bearer"
              },
              Scheme = "oauth2",
              Name = "Bearer",
              In = ParameterLocation.Header,

            },
            new List<string>()
          }
        });
    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
});
#endregion
#region policy
#endregion
#region DI
#region Service
services.AddTransient<IBoGiaoDucContextProvider, BoGiaoDucContextProvider>();
services.AddTransient<IQuanLyThuPhiContextProvider, QuanLyThuPhiContextProvider>();
services.AddSingleton<IQiCache, QiCache>();
services.AddTransient<INguoiDungService, NguoiDungService>();
services.AddScoped<IWorkContextService, WorkContextService>();
services.AddTransient<IPermissionService, PermissionService>();
services.AddTransient<IAuthenticateService, AuthenticateService>();
services.AddTransient<ICommonService, CommonService>();
#endregion
#region DomainService
services.AddTransient<IContextDomainService, ContextDomainService>();
#endregion
#region Background Service
// Hosted Service
services.AddHostedService<TimedHostedService>();
services.AddHostedService<CommonBackgroundTaskBackgroundService>();
// Queue
services.AddSingleton<ICommonBackgroundTaskQueue, CommonBackgroundTaskQueue>();

#endregion
#region config
services.AddHttpContextAccessor();
services.AddAutoMapper(typeof(AutoMapperProfile).Assembly);

//Upload
services.Configure<IISServerOptions>(options =>
{
    options.MaxRequestBodySize = ConfigurationHelper.UploadFileLimit;
});
services.Configure<KestrelServerOptions>(options =>
{
    options.Limits.MaxRequestBodySize = ConfigurationHelper.UploadFileLimit; // if don't set default value is: 30 MB
});
services.Configure<FormOptions>(options =>
{
    options.ValueLengthLimit = ConfigurationHelper.UploadFileLimit;
    options.MultipartBodyLengthLimit = ConfigurationHelper.UploadFileLimit; // if don't set default value is: 128 MB
    options.MultipartHeadersLengthLimit = ConfigurationHelper.UploadFileLimit;
});

// Compression
builder.Services.AddResponseCompression(options =>
{
    options.EnableForHttps = true;
    options.Providers.Add<BrotliCompressionProvider>();
    options.Providers.Add<GzipCompressionProvider>();
});
builder.Services.Configure<BrotliCompressionProviderOptions>(options =>
{
    options.Level = CompressionLevel.Fastest;
});
builder.Services.Configure<GzipCompressionProviderOptions>(options =>
{
    options.Level = CompressionLevel.SmallestSize;
});

#endregion
#endregion

#region Application
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(
           Path.Combine(builder.Environment.ContentRootPath, "FileFolder/Static")),
    RequestPath = "/File"
});
app.UseCors(QI_CORS);

app.UseHttpsRedirection();

app.UseAuthorization();
app.UseResponseCompression();

app.UseMiddleware<WorkContextMiddleware>();

app.MapControllers();


app.Run();
#endregion