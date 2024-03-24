using ThomasGreg_Application.Services;
using ThomasGreg_Domain.Repositories;
using ThomasGreg_Domain.Services;
using ThomasGreg_Repository.Repos;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IClienteRepository, ClienteRepository>();
builder.Services.AddSingleton<ILogradouroRepository, LogradouroRepository>();

builder.Services.AddSingleton<IClienteService, ClienteService>();
builder.Services.AddSingleton<ILogradouroService, LogradouroService>();

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
