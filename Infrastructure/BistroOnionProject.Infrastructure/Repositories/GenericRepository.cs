using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BistroOnionProject.Infrastructure.Persistence.Repositories
{
    public interface GenericRepository<T> where T : class
    {
        Task<T?> GetByIdAsync(int id);
        Task CreateAsync(T t);
        Task<List<T?>> GetAllAsync();
        Task UpdateAsync(T t);
        Task DeleteAsync(int id);
    }
}
