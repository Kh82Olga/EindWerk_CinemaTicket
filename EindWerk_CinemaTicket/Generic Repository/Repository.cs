using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EindWerk_CinemaTicket.Generic_Repository
{
    public class Repository<TDbContext> : IRepository where TDbContext : DbContext
    {
        private readonly TDbContext _dbContext;
        public Repository(TDbContext context)
        {
            _dbContext = context;
        }
        public async Task CreateAsync<T>(T entity) where T : class
        {
            _dbContext.Set<T>().Add(entity);
            _ = await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync<T>(T entity) where T : class
        {
            _dbContext.Set<T>().Remove(entity);
            _ = await (_dbContext.SaveChangesAsync());
        }

        public async Task<List<T>> SelectAllAsync<T>() where T : class
        {
            return _ = await _dbContext.Set<T>().ToListAsync();
        }

        public async Task<T> SelectByIdAsync<T>(int id) where T : class
        {
            return _ = await _dbContext.Set<T>().FindAsync(id);
        }

        public async Task UpdateAsync<T>(T entity) where T : class
        {
            _dbContext.Set<T>().Update(entity);
            _ = await _dbContext.SaveChangesAsync();
        }
    }
}
