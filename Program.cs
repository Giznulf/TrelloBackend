using System;
using System.Text.RegularExpressions;
using Microsoft.EntityFrameworkCore;
using TrelloBackend.Models;

var builder = WebApplication.CreateBuilder(args);

string connection = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddControllers();
builder.Services.AddCors();

builder.Services.AddDbContext<UsersContext>(opt =>
    opt.UseMySql(connection, new MySqlServerVersion(new Version(8, 0, 31))));

builder.Services.AddEndpointsApiExplorer();


var app = builder.Build();

app.UseCors(builder => builder.AllowAnyOrigin()
                             .AllowAnyMethod()
                             .AllowAnyHeader()
                             .WithExposedHeaders());

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
