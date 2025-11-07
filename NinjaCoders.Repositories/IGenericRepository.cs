namespace NinjaCoders.Repositories
{
    public interface IGenericRepository<T>  where T : class
    {
        Task<T?> GetByIdAsync(object id);
        Task AddAsync(T entity);
        void Update(T entity);
        void Delete(T entity);
        Task SaveAsync();
    }
}
