using Microsoft.EntityFrameworkCore;
using NinjaCoders.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjaCoders.Repositories
{
    public class Repository<T> : IGenericRepository<T> where T : class        
    {
        private readonly AppDBContext _context;
        private readonly DbSet<T> _dbSet;

        public Repository(AppDBContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        public async Task<T?> GetByIdAsync(object id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

    }
}
