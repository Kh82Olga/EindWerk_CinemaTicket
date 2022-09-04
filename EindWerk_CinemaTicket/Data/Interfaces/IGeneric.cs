using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace EindWerk_CinemaTicket.Data.Interfaces
{
    public interface IGeneric<T> where T : class,IBase, new()
    {
        Task<List<T>> GetAllAsync();
        Task<List<T>> GetAllAsync(params Expression<Func<T, object>>[] includeProperties);
        Task<T> GetByIdAsync(int Id);
        Task InsertAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(int Id);
    }
}
