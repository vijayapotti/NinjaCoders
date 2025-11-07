namespace NinjaCoders.Services
{
    public interface IGenericService<T> where T : class
    {
        Task<T?> GetByIdAsync(object id);
        Task AddAsync(T entity);
        void Update(T entity);
        Task DeleteAsync(object id);
        Task SaveAsync();
    }
}
