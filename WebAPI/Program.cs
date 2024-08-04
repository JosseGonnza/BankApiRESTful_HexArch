using Application;
using Persistence;
using Shared;

var builder = WebApplication.CreateBuilder(args);
    
ConfigurationManager configuration = builder.Configuration;

IWebHostEnvironment environment = builder.Environment;

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Al hacer WebAPI una referencia a la capa Application, podemos llamar a los servicios de ServiceExtensions
builder.Services.AddApplicationLayer();
builder.Services.AddShareInfraestructure(configuration);
builder.Services.AddPersistenceInfraestructure(configuration);

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
