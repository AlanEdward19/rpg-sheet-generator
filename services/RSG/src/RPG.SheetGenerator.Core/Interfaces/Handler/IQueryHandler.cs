namespace RPG.SheetGenerator.Core.Interfaces;

public interface IQueryHandler<T>
{
    Task<List<T>> GetAll();
    Task<T> GetById(int id);
    Task<T> GetById(Guid id);
}