using Infrastructure.Persistence.Contexts;
using Infrastructure.Shared.Services.Implementstions;
using Infrastructure.Shared.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using Application.Services;
using Infrastructure.Persistence.Repositories;
using Microsoft.AspNetCore.Identity;
using Domain.Identity.DbModels.Security;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Infrastructure.Identity.Context;
using Application.Services.Implementations.Security;
using Application.Services.Interfaces.Security;
using Microsoft.FeatureManagement;
using Infrastructure.Identity.Seed;
using Domain.Identity.Settings;
using Infrastructure.Identity.RepositoryBase;
using Infrastructure.Persistence.Repositories.Interfaces.Welfare;
using Infrastructure.Persistence.RepositoryBase;
using Infrastructure.Shared.GenericRepository;

var builder = WebApplication.CreateBuilder(args);

// Add layers via DI extensions
builder.Services.AddApplicationLayer();
builder.Services.AddInfrastructureLayer();


// Add services to the container.
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddDbContext<IdentityContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

#region Shared Repository
builder.Services.AddScoped(typeof(IApplicationRepository<>), typeof(ApplicationRepository<>));
    builder.Services.AddScoped(typeof(IIdentityRepository<>), typeof(IdentityRepository<>));
#endregion


#region Identity

builder.Services.AddIdentity<ApplicationUser, ApplicationRole>()
            .AddEntityFrameworkStores<IdentityContext>()
            .AddDefaultTokenProviders(); // for email confirmation, reset password, etc.

builder.Services.Configure<JWTSettings>(builder.Configuration.GetSection("JwtSettings"));
//builder.Services.AddSingleton<IJwtService, JwtService>(); // Or however you're injecting it

// 3. Configure Identity options (optional)
builder.Services.Configure<IdentityOptions>(options =>
        {
            options.Password.RequireDigit = true;
            options.Password.RequireUppercase = false;
            options.Password.RequiredLength = 6;
            options.User.RequireUniqueEmail = true;
        });
#endregion

builder.Services.AddScoped<IEmailService, Application.Services.Implementations.Security.MailService>();
builder.Services.AddScoped<IAccountService, AccountService>();
builder.Services.AddScoped<IDateTimeService, DateTimeService>();
builder.Services.AddFeatureManagement();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    await IdentitySeeder.SeedRolesAsync(services);
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
