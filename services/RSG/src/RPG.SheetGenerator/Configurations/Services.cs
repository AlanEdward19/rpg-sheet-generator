using Microsoft.EntityFrameworkCore;
using RPG.SheetGenerator.Application.Commands.CreateAlignment;
using RPG.SheetGenerator.Application.Queries.GetAlignment;
using RPG.SheetGenerator.Core.Entities;
using RPG.SheetGenerator.Core.Interfaces;
using RPG.SheetGenerator.Infrastructure.Context;
using RPG.SheetGenerator.Infrastructure.Repository;
using Attribute = RPG.SheetGenerator.Core.Entities.Attribute;

namespace BDS.TransferPrice.Configuration;

public static class Services
{
    public static IServiceCollection ConfigureServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<RSGDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("Database")));

        services.AddScoped<CreateUpdateAlignmentCommandHandler>();
        services.AddScoped<GetAlignmentHandler>();

        services.AddScoped<IRepository<Alignment>, Repository<Alignment>>();
        services.AddScoped<IRepository<Attribute>, Repository<Attribute>>();
        services.AddScoped<IRepository<Background>, Repository<Background>>();
        services.AddScoped<IRepository<Campaign>, Repository<Campaign>>();
        services.AddScoped<IRepository<Character>, Repository<Character>>();
        services.AddScoped<IRepository<Class>, Repository<Class>>();
        services.AddScoped<IRepository<Inventory>, Repository<Inventory>>();
        services.AddScoped<IRepository<Item>, Repository<Item>>();
        services.AddScoped<IRepository<ItemType>, Repository<ItemType>>();
        services.AddScoped<IRepository<Language>, Repository<Language>>();
        services.AddScoped<IRepository<Player>, Repository<Player>>();
        services.AddScoped<IRepository<Proficiency>, Repository<Proficiency>>();
        services.AddScoped<IRepository<Race>, Repository<Race>>();

        return services;
    }
}