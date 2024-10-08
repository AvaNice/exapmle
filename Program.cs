using Microsoft.EntityFrameworkCore;
using MyFirstApi.DataAccess;
using MyFirstApi.Mapping;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connection = string.Empty;
connection = Environment.GetEnvironmentVariable("SQL_CONNECTION_STRING");

builder.Services.AddDbContext<DbContext, FilmDb>(options =>
    options.UseSqlServer(connection));

builder.Services.AddTransient<IFilmRepo, FilmRepo>();

builder.Services.AddAutoMapper(typeof(FirstApiMappingProfile));

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