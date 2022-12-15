using System;
using System.Text.RegularExpressions;
using Microsoft.EntityFrameworkCore;
using TrelloBackend.Models;

using (UsersContext db = new UsersContext())
{
    User user1 = new User {Id = 48, Name = "Tom", Password = "desda" };
    User user2 = new User {Id = 145, Name = "Alice", Password = "gefdf" };

    db.Users.AddRange(user1, user2);
    db.SaveChanges();
}
// получение данных
using (UsersContext db = new UsersContext())
{
    var users = db.Users.ToList();
    Console.WriteLine("Список объектов:");
    foreach (User u in users)
    {
        Console.WriteLine($"{u.Id}.{u.Name} - {u.Password}");
    }
}

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddCors();

//builder.Services.AddDbContext<UsersContext>(opt =>
 //   opt.UseInMemoryDatabase("Users"));
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

app.UseCors(builder => builder.AllowAnyOrigin()
                             .AllowAnyMethod()
                             .AllowAnyHeader()
                             .WithExposedHeaders());

//app.Map("/", () => "Index Page");

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

//app.MapPost("api/users",);

app.MapControllers();

app.Run();
