using FridgeManager.Services.Implementations;
using FridgeManager.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.



builder.Services.AddControllers();

FridgeManager.DAL.Dependencies.ConfigureServices(builder.Configuration, builder.Services);

builder.Services.AddScoped(typeof(IFridgeService),typeof(FridgeService));

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
