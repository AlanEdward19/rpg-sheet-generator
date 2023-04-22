using Microsoft.EntityFrameworkCore;
using RPG.SheetGenerator.Application.Commands.CreateAlignment;
using RPG.SheetGenerator.Application.Commands.CreateUpdateAttribute;
using RPG.SheetGenerator.Application.Commands.CreateUpdateBackground;
using RPG.SheetGenerator.Application.Commands.CreateUpdateCharacter;
using RPG.SheetGenerator.Application.Commands.CreateUpdateClass;
using RPG.SheetGenerator.Application.Commands.CreateUpdateInventory;
using RPG.SheetGenerator.Application.Commands.CreateUpdateItem;
using RPG.SheetGenerator.Application.Commands.CreateUpdateItemType;
using RPG.SheetGenerator.Application.Commands.CreateUpdateLanguage;
using RPG.SheetGenerator.Application.Commands.CreateUpdatePlayer;
using RPG.SheetGenerator.Application.Commands.CreateUpdateProficiency;
using RPG.SheetGenerator.Application.Commands.CreateUpdateRace;
using RPG.SheetGenerator.Application.Queries.GetAlignment;
using RPG.SheetGenerator.Application.Queries.GetAttribute;
using RPG.SheetGenerator.Application.Queries.GetBackground;
using RPG.SheetGenerator.Application.Queries.GetCharacter;
using RPG.SheetGenerator.Application.Queries.GetClass;
using RPG.SheetGenerator.Application.Queries.GetInventory;
using RPG.SheetGenerator.Application.Queries.GetItem;
using RPG.SheetGenerator.Application.Queries.GetItemType;
using RPG.SheetGenerator.Application.Queries.GetLanguage;
using RPG.SheetGenerator.Application.Queries.GetPlayer;
using RPG.SheetGenerator.Application.Queries.GetProficiency;
using RPG.SheetGenerator.Application.Queries.GetRace;
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

        #region Commands

        services.AddScoped<CreateUpdateAlignmentCommandHandler>();
        services.AddScoped<CreateUpdateAttributeCommandHandler>();
        services.AddScoped<CreateUpdateBackgroundCommandHandler>();
        services.AddScoped<CreateUpdateCharacterCommandHandler>();
        services.AddScoped<CreateUpdateClassCommandHandler>();
        services.AddScoped<CreateUpdateInventoryCommandHandler>();
        services.AddScoped<CreateUpdateItemCommandHandler>();
        services.AddScoped<CreateUpdateItemTypeCommandHandler>();
        services.AddScoped<CreateUpdateLanguageCommandHandler>();
        services.AddScoped<CreateUpdatePlayerCommandHandler>();
        services.AddScoped<CreateUpdateProficiencyCommandHandler>();
        services.AddScoped<CreateUpdateRaceCommandHandler>();

        #endregion

        #region Queries

        services.AddScoped<GetAlignmentHandler>();
        services.AddScoped<GetAttributeHandler>();
        services.AddScoped<GetBackgroundHandler>();
        services.AddScoped<GetCharacterHandler>();
        services.AddScoped<GetClassHandler>();
        services.AddScoped<GetInventoryHandler>();
        services.AddScoped<GetItemHandler>();
        services.AddScoped<GetItemTypeHandler>();
        services.AddScoped<GetLanguageHandler>();
        services.AddScoped<GetPlayerHandler>();
        services.AddScoped<GetProficiencyHandler>();
        services.AddScoped<GetRaceHandler>();

        #endregion

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