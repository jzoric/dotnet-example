using Microsoft.EntityFrameworkCore;
using todo.Models;

var connectionString = @"Server=127.0.0.1,1433;;Database=todos;User=sa;Password=strong123#;";

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<TodoContext>(opt => opt.UseSqlServer(connectionString));

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.UseCors(x => x
    .AllowAnyMethod()
    .AllowAnyHeader()
    .SetIsOriginAllowed(origin => true)
    .AllowCredentials()
    );

app.MapControllers();

app.Run();
