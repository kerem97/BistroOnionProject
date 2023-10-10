using BistroOnionProject.Domain.Entities;
using BistroOnionProject.Infrastructure.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BistroOnionProject.Infrastructure.Persistence.EntityFramework
{
    public class EfDishRepository : IDishRepository
    {
        public Task CreateAsync(Dish t)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Dish?>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Dish?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Dish t)
        {
            throw new NotImplementedException();
        }
    }
}
