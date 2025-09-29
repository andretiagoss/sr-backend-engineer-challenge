using Microsoft.Extensions.DependencyInjection;

namespace Taller.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplicationLayer(this IServiceCollection services)
    {
        services.AddMediatR(cfg =>
        {
            cfg.RegisterServicesFromAssembly(typeof(DependencyInjection).Assembly);
        });

        services.AddAutoMapper(typeof(DependencyInjection).Assembly);

        return services;
    }
}


