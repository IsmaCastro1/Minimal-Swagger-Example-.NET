using Microsoft.EntityFrameworkCore;
using SwaggerAPi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<WeatherDbContext>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapGet("/GetAllProvinces", async (WeatherDbContext context) => await context.Provinces.ToListAsync());

app.MapGet("/GetProvince/{id}" , async (WeatherDbContext context, String id) => await context.Provinces.FindAsync(id) );

app.MapGet("/GetMunicipalityByProvince/{id}", async (WeatherDbContext context, String id) => 
                    await context.Municipalities.Where(Municipality => Municipality.Codprov == id).ToListAsync() 
                );



app.Run();
