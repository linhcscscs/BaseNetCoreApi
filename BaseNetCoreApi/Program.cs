using BaseNetCoreApi.Helper;
using BaseNetCoreApi.Infrastructure.CacheProvider;
using BaseNetCoreApi.Infrastructure.ContextProvider;
using BaseNetCoreApi.Infrastructure.Models.BO_GIAO_DUCEntities;
using BaseNetCoreApi.Infrastructure.Models.QUAN_LY_THU_PHIEntities;
using BaseNetCoreApi.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Logging.ClearProviders();
builder.Logging.AddConsole();
#region Properties
const string QI_CORS = "QI_CORS";
#endregion
IConfiguration config = new ConfigurationBuilder()
                          .SetBasePath(Directory.GetCurrentDirectory())
                          .AddJsonFile("appsettings.json", false, false)
                          .AddEnvironmentVariables()
                          .Build();
var services = builder.Services;
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
                              .AllowAnyMethod();
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
                                  policy.WithOrigins("")
                              .AllowAnyMethod();
                              });
        });
    }
}
#endregion
#region Bindding Configure Helper
ConfigurationHelper.Configuration = config;
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

        ValidAudience = config["JWT:ValidAudience"],
        ValidIssuer = config["JWT:ValidIssuer"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["JWT:Secret"]!))
    };
});
#endregion
#region DI
services.AddTransient<IContextProvider<BO_GIAO_DUCEntities>, BoGiaoDucContextProvider>();
services.AddTransient<IContextProvider<QUAN_LY_THU_PHIEntities>, QuanLyThuPhiContextProvider>();
services.AddSingleton<IQiCache, QiCache>();
services.AddTransient<INguoiDungService, NguoiDungService>();
#endregion

#region Application
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(QI_CORS);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();


app.Run();
#endregion