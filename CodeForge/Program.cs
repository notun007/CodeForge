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

var builder = WebApplication.CreateBuilder(args);

// Add layers via DI extensions
builder.Services.AddApplicationLayer();
builder.Services.AddInfrastructureLayer();

// Add services to the container.
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddDbContext<IdentityContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

#region Identity
builder.Services.AddIdentity<ApplicationUser, ApplicationRole>()
            .AddEntityFrameworkStores<IdentityContext>()
            .AddDefaultTokenProviders(); // for email confirmation, reset password, etc.

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
