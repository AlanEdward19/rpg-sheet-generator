using Microsoft.EntityFrameworkCore;
using RPG.SheetGenerator.Infrastructure.Context;

namespace BDS.TransferPrice.Configuration;

public static class Services
{
    public static IServiceCollection ConfigureServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<RSGDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("Database")));

        return services;
    }
}