//using System.Runtime.InteropServices.Marshalling;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.Configuration;
//using Microsoft.OpenApi.Models;
//using MMO.API.Application;
//using MMO.API.Core.Entities;
//using MMO.API.Infrastructure;
//using MMO.API.Infrastructure.IoC;

//var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.

//builder.Services.AddControllers();
//builder.Services.AddDependencyResolver();
//// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();

//builder.Services.AddDbContext<MMO_DbContext>(options =>
//{
//    options.UseSqlServer(Configuration.GetConnectionString("Shopbridge_Context"));
//    //options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
//});
//builder.Services.AddSwaggerGen(c =>
//{
//    c.SwaggerDoc("v1", new OpenApiInfo
//    {
//        Version = "v1",
//        Title = "MMO CRUD API",
//        Description = "MMO CRUD API",
//    });
//});

//builder.Services
//    .AddApplicationServices();

//var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseDeveloperExceptionPage();
//    app.UseSwagger();
//    app.UseSwaggerUI(c => {
//        c.SwaggerEndpoint("/swagger/v1/swagger.json", "API V1");
//    });
//}

//app.UseHttpsRedirection();

//app.UseRouting();

//app.UseAuthorization();

//app.MapControllers();

//app.Run();

using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MMO.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
