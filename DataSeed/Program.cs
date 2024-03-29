﻿using DataSeed.Infrastructure;
using DataSeed.SeedServices;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var host = Host.CreateDefaultBuilder()
    .ConfigureAppConfiguration((context, builder) =>
{
    var env = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
    if (string.IsNullOrWhiteSpace(env))
    {
        throw new Exception("ASPNETCORE_ENVIRONMENT env variable not set.");
    }

    context.HostingEnvironment.EnvironmentName = env;
            
    builder
        .AddJsonFile("appsettings.json", optional: false, reloadOnChange: false)
        .AddJsonFile($"appsettings.{env}.json", optional: false, reloadOnChange: false);
}).ConfigureServices((context, services) =>
{
    services.AddCosmosDbClient(context.Configuration);
    services.AddSingleton<FrogSpawn>();
}).Build();

var seed = host.Services.GetRequiredService<FrogSpawn>();
await seed.SeedFrogs();