using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore;
using ApiPagamento.Models;
using ApiPagamento.PagamentosDbContext;



var builder = WebApplication.CreateBuilder(args);

string? strConnection = builder.Configuration.GetConnectionString("Default Connection");

        builder.Services.AddDbContext<PagamentoDbContext>
        (options => options.UseSqlServer("Server=BSGTI-NB002;Database=PagamentosDB;User Id=vinicius.lima;Password=1234567;Encrypt=True;TrustServerCertificate=True") );

builder.Services.AddControllers();
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
