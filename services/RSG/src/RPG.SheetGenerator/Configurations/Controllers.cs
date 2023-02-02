namespace BDS.TransferPrice.Configuration;

public static class Controllers
{
    public static IServiceCollection ConfigureController(this IServiceCollection services)
    {
        services.AddControllers();

        return services;
    }
}