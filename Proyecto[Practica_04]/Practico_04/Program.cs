using Data;
using Data.Domain;
using Data.Interfaces;
using Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Practico_04.Interfaces;
using Practico_04.Models;
using Practico_04.Services;
using Practico_04.Utils;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// db context
var cnnstring = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<TurnoDbContext>(options =>options.UseSqlServer(cnnstring));

// inyeccion de repositorios
builder.Services.AddScoped<IRepository<Servicio>, ServicioRepository>();
builder.Services.AddScoped<IRepository<Turno>, TurnoRepository>();
builder.Services.AddScoped<IRepository<DetalleTurno>, DetalleRepository>();
//inyeccion de servicios
builder.Services.AddScoped<IManager<ServicioDTO>, ServicioManager>();
builder.Services.AddScoped<IManager<TurnoDTO>, TurnoManager>();
builder.Services.AddScoped<IManager<DetalleDTO>, DetalleManager>();
//inyeccion de mapeador
builder.Services.AddScoped<IMapper<ServicioDTO, Servicio>, ServicioMapper>();
builder.Services.AddScoped<IMapper<TurnoDTO, Turno>, TurnoMapper>();
builder.Services.AddScoped<IMapper<DetalleDTO, DetalleTurno>, DetalleMapper>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

//using (var scope = app.Services.CreateScope())
//{
//    var context = scope.ServiceProvider.GetService<TurnoDbContext>();
//    context.Database.Migrate();
//}

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
