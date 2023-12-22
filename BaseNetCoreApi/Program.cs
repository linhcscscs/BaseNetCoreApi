using BaseNetCoreApi.BackgroundTask;
using BaseNetCoreApi.DomainService;
using BaseNetCoreApi.DomainService.Interface;
using BaseNetCoreApi.Helper;
using BaseNetCoreApi.Infrastructure.CacheProvider;
using BaseNetCoreApi.Infrastructure.ContextProvider;
using BaseNetCoreApi.Infrastructure.ContextProvider.Interface;
using BaseNetCoreApi.Infrastructure.Models.PHO_CAP_GDEntities;
using BaseNetCoreApi.Infrastructure.MongoDBClient;
using BaseNetCoreApi.Infrastructure.MongoDBClient.Interface;
using BaseNetCoreApi.Infrastructure.Repository;
using BaseNetCoreApi.Infrastructure.Repository.Interface;
using BaseNetCoreApi.Middleware;
using BaseNetCoreApi.Models.AutoMapperProfile;
using BaseNetCoreApi.Models.Collection;
using BaseNetCoreApi.Models.Collection.Interface;
using BaseNetCoreApi.Models.Repository;
using BaseNetCoreApi.Services;
using BaseNetCoreApi.Services.Interface;
using BaseNetCoreApi.Values;
using Microsoft.AspNetCore.Authentication.JwtBearer;
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
services.AddDbContext<PHO_CAP_GDEntities>(options =>
                options.UseSqlServer(config.GetConnectionString("ConnectionStrings:PHO_CAP_GDEntities")));
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
#region Domain Service
services.AddScoped<IWorkContextService, WorkContextService>();
#endregion
#region Service
services.AddSingleton<IQiCache, QiCache>();
services.AddTransient<INguoiDungService, NguoiDungService>();
services.AddTransient<IPermissionService, PermissionService>();
services.AddTransient<IAuthenticateService, AuthenticateService>();
#endregion
#region Repository
#region Base Repository
services.AddScoped<IPhoCapGDContextProvider, PhoCapGDContextProvider>();
services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
services.AddScoped<IUnitOfWork, UnitOfWork>();
#endregion
services.AddScoped<IMenuRepository, MenuRepository>();
services.AddScoped<IGroupUserMenuRepository, GroupUserMenuRepository>();
services.AddScoped<IGroupUserRepository, GroupUserRepository>();
services.AddScoped<INguoiDungRepository, NguoiDungRepository>();
services.AddScoped<IRefreshTokenRepository, RefreshTokenRepository>();
services.AddScoped<IDmCapHocRepository, DmCapHocRepository>();
services.AddScoped<IDmTinhRepository, DmTinhRepository>();
services.AddScoped<IDmHuyenRepository, DmHuyenRepository>();
services.AddScoped<IDmXaRepository, DmXaRepository>();
#endregion
#region Collection
#region Base Collection
services.AddScoped<IMongoDbClientProvider, MongoDbClientProvider>();
#endregion
services.AddScoped<ILogSYSCollection, LogSYSCollection>();
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