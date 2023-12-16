using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using SheepYourHackApp.Server.Repositories;
using SheepYourHackApp.Server.Repositories.Interfaces;
using SheepYourHackApp.Server.UnitsOfWork;

namespace SheepYourHackApp.Server.HttpPipelines;

public static class ServiceCollectionBuilderExtensions
{
    public static IServiceCollection AddDependencyInjection(this IServiceCollection services)
    {
        services.AddScoped<IUnitOfWork, UnitOfWork>();

        return services;
    }
}
