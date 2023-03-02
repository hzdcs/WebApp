using WebApp;
using WebApp.Interfaces;
using WebApp.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebApp.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<WebAppContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("WebAppContext") ?? throw new InvalidOperationException("Connection string 'WebAppContext' not found.")));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IWeatherService, WeatherServiceImpl>();
builder.Services.AddSingleton<ISummaryService, SummaryServiceImpl>();
builder.Services.AddSingleton<IToDoService, ToDoServiceImpl>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseStaticFiles();

app.UseStatusCodePagesWithRedirects("/FeatureError.html");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
