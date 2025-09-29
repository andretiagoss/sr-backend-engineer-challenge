using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Taller.Application.Interfaces;
using Taller.Domain.Interfaces;
using Taller.Infrastructure.Persistence;
using Taller.Infrastructure.Persistence.Repositories;
using Taller.Infrastructure.Security;

namespace Taller.Infrastructure;

public static class DependencyInjection
{
    public static async Task<IServiceCollection> AddInfrastructureLayer(this IServiceCollection services, IConfiguration configution)
    {
        var keyVaultUrl = configution["KeyVault:Url"];
        services.AddSingleton<ISecretProvider>(sp => new SecretProvider(keyVaultUrl!));

        var serviceProvider = services.BuildServiceProvider();
        var secretProvider = serviceProvider.GetRequiredService<ISecretProvider>();
        
        var connectionString = await secretProvider.GetSecretAsync("DatabaseConnectionString");

        services.AddDbContext<DataContext>(options => options.UseSqlServer(connectionString));
        services.AddScoped<IReportRepository, ReportRepository>();
        
        return services;
    }
}
