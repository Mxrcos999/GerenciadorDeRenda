using GerenciadorDeRendaInfra.Context;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

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
