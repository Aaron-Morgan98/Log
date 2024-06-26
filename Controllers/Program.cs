﻿using Microsoft.EntityFrameworkCore;
using DataLayer;
using DataLayer.Interfaces;
using DataLayer.Repositories;
using ServiceLayer.Interfaces;
using ServiceLayer.Services;




var builder = WebApplication.CreateBuilder(args);

// Add CORS services
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowOrigin",
        builder => builder.WithOrigins("http://localhost:5173")
                          .AllowAnyHeader()
                          .AllowAnyMethod());
});

//connect DB
var connectionString = builder.Configuration.GetConnectionString("GameLog");
builder.Services.AddDbContext<GameLogContext>(options => options.UseSqlite(connectionString));

builder.Services.AddScoped<IGameLogRepository, GameLogRepository>();
builder.Services.AddScoped<IGameLogService, GameLogService>();

//builder.Services.AddAutoMapper(typeof(GameMapper)); //config for mapping

builder.Services.AddControllersWithViews(); // add MVC services

var app = builder.Build();



app.UseStaticFiles();
app.UseRouting();

app.UseCors("AllowOrigin");

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=GameLog}/{action=Index}/{id?}" //Config route for MVC
    );



app.Run();

