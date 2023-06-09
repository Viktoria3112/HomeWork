using Microsoft.EntityFrameworkCore;
using PetInfrastructure;
using System;
using PetSalon;
using Pets.Services.Mapper;
using Microsoft.AspNetCore.Builder;
using Pets.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.RegisterDataBase();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(ApplicationProfile));

builder.Services.AddTransient<IPetsService, AnimalService>();
builder.Services.AddTransient<IServicesService, ServicesService>();
builder.Services.AddTransient<IWorkerService, WorkersService>();
builder.Services.AddTransient<IPersonService, PersonsService>();

var app = builder.Build();

await MigrateDatabase(app);

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}



app.UseAuthorization();

app.MapRazorPages();

app.Run();

async Task MigrateDatabase(WebApplication webApplication)
{
    using var scope = webApplication.Services.CreateScope();
    var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    if (context == null)
        throw new Exception("Cannot initialize the database context");
    await context.Database.MigrateAsync();
}