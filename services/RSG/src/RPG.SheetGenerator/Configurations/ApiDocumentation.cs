namespace BDS.TransferPrice.Configuration;

public static class ApiDocumentation
{
    public static IServiceCollection ConfigureApiDocumentarion(this IServiceCollection services)
    {
        services.AddApiVersioning(config =>
        {
            config.DefaultApiVersion = new ApiVersion(1, 0);
            config.AssumeDefaultVersionWhenUnspecified = true;
            config.ReportApiVersions = true;
        });

        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo {Title = "RPG.SheetGenerator.API", Version = "v1"});
        });

        return services;
    }

    public static IApplicationBuilder ConfigureApiDocumentarionUi(this IApplicationBuilder app)
    {
        app.UseDeveloperExceptionPage();
        app.UseSwagger();
        app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "RPG.SheetGenerator.API v1"));

        return app;
    }
}