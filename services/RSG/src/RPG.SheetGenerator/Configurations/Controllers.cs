using RPG.SheetGenerator.API.Filters;

namespace BDS.TransferPrice.Configuration;

public static class Controllers
{
    public static IServiceCollection ConfigureController(this IServiceCollection services)
    {
        services
            .AddControllers(options =>
            {
                options.Filters.Add<ValidationFilter>();
            });

        return services;
    }
}