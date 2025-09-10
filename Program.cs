using Microsoft.EntityFrameworkCore;
using ProvaCsharp.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ProvaCscharpDbContext>(
    options => options.UseSqlServer(
        Environment.GetEnvironmentVariable("SQL_CONNECTION")
    )
);

var app = builder.Build();

app.Run();
