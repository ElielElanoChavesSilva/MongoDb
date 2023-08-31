using LojinhaServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using MongoDB.Driver;

namespace LojaCarrosServer.Extensions;
public static class ServiceExtensions
{
    public static void ConfigureCors(this IServiceCollection services) 
    { 
        services.AddCors(StringSplitOptions => {
            StringSplitOptions.AddPolicy("CorsPolicy",
            builderas => builderas.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
        });
    }

    public static void ConfigureMongoDBSettings(this IServiceCollection services){
        services.Configure<MongoDBSettings>(
            ConfigureCors.GetSection("MongoDBSettings")
        );

        services.AddSingleton<IMongoDatabase>(options => {
            var settings = ConfigureCors.GetSection("MongoDBSettings").Get<MongoDBSettings>();
            var client = new MongoClient(settings.DatabaseName);
        });
    }
}