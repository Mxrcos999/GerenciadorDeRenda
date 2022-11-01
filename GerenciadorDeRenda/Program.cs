using GerenciadorDeRendaApp.Interfaces;
using GerenciadorDeRendaApp.services;
using GerenciadorDeRendaDomain.Interfaces;
using GerenciadorDeRendaInfra.Context;
using GerenciadorDeRendaInfra.Repository;
using GerenciadorDeRendaInfra.UnitOfWork;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);


builder.Services.AddCors();
// Add services to the container.

builder.Services.AddControllers();
//services.AddDbContext<ApplicationDbContext>(options =>
//options.UseNpgsql(
//                  Configuration.GetConnectionString("stringConnection")));
//services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddDbContext<AppDbContext>(opts => opts.UseNpgsql(
         builder.Configuration.GetConnectionString("strConnection")));
    
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ISvcConta, SvcConta>();

//Injeções de dependencia
builder.Services.AddScoped<IRepositoryConta, RepositoryConta>();
builder.Services.AddScoped<ISvcConta, SvcConta>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();


var app = builder.Build();
app.UseCors(C =>
{
    C.AllowAnyHeader();
    C.AllowAnyMethod();
    C.AllowAnyOrigin();
});

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

