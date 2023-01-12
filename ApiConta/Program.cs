using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore;
using ApiConta.Models;
using ApiConta.ContasDbContext;
using Microsoft.Identity;
using System.Text;
using ApiConta;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);

     
        string? strConnection = builder.Configuration.GetConnectionString("Default Connection");

        builder.Services.AddDbContext<ContaDbContext>
        (options => options.UseSqlServer("Server=BSGTI-NB002;Database=ContasDB;User Id=vinicius.lima;Password=1234567;Encrypt=True;TrustServerCertificate=True") );

        


        

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

        app.UseAuthentication();
        app.UseAuthorization();

        app.MapGet("/", ()=> "Hello World" );

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    


