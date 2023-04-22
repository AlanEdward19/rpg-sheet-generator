using System.Linq.Expressions;
using System.Reflection.Metadata;
using Microsoft.EntityFrameworkCore;
using RPG.SheetGenerator.Core.Entities;
using RPG.SheetGenerator.Core.Interfaces;
using RPG.SheetGenerator.Infrastructure.Context;
using RPG.SheetGenerator.Infrastructure.Extensions;
using Attribute = RPG.SheetGenerator.Core.Entities.Attribute;

namespace RPG.SheetGenerator.Infrastructure.Repository;

public class Repository<T> : IRepository<T> where T : class
{
    private readonly RSGDbContext _dbContext;
    private readonly DbSet<T> _dbSet;
    
    public Repository(RSGDbContext dbContext)
    {
        _dbContext = dbContext;
        _dbSet = dbContext.Set<T>();
    }
    public async Task AddAsync(T entity)
    {
        await _dbSet.AddAsync(entity);

        await _dbContext.SaveChangesAsync();
    }
    public async Task UpdateAsync(T entity, int id)
    {
        var entityDb = await GetById(id);

        foreach (var property in _dbSet.Entry(entityDb).Properties)
        {
            var propertyName = property.Metadata.Name;

            if (propertyName.ToLower() != "id")
                property.CurrentValue = _dbSet.Entry(entity).Property(propertyName).CurrentValue;
        }

        _dbSet.Update(entityDb);

        await _dbContext.SaveChangesAsync();
    }
    public async Task UpdateAsync(T entity, Guid id)
    {
        var entityDb = await GetById(id);

        foreach (var property in _dbSet.Entry(entityDb).Properties)
        {
            var propertyName = property.Metadata.Name;

            if (propertyName.ToLower() != "id")
                property.CurrentValue = _dbSet.Entry(entity).Property(propertyName).CurrentValue;
        }

        _dbSet.Update(entityDb);

        await _dbContext.SaveChangesAsync();
    }
    public async Task<List<T>> GetAll() => await _dbSet.VirtualInclude().ToListAsync();
    public async Task<T> GetById(int id)
    {
        var parameter = Expression.Parameter(typeof(T), "x");
        var property = Expression.Property(parameter, "Id");
        var lambdaExpression = Expression.Lambda<Func<T, bool>>(Expression.Equal(property, Expression.Constant(id)), parameter);


        return await _dbSet.VirtualInclude().Where(lambdaExpression).FirstOrDefaultAsync();
    }
    public async Task<T> GetById(Guid id)
    {
        var parameter = Expression.Parameter(typeof(T), "x");
        var property = Expression.Property(parameter, "Id");
        var lambdaExpression = Expression.Lambda<Func<T, bool>>(Expression.Equal(property, Expression.Constant(id)), parameter);


        return await _dbSet.VirtualInclude().Where(lambdaExpression).FirstOrDefaultAsync();
    }
    public async Task DeleteById(int id)
    {
        var entityDb = await GetById(id);

        _dbSet.Remove(entityDb);

        await _dbContext.SaveChangesAsync();
    }
    public async Task DeleteById(Guid id)
    {
        var entityDb = await GetById(id);

        _dbSet.Remove(entityDb);

        await _dbContext.SaveChangesAsync();
    }
}