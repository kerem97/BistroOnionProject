using BistroOnionProject.Domain.Entities;
using BistroOnionProject.Infrastructure.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BistroOnionProject.Infrastructure.Persistence.EntityFramework
{
    public class EfOurDishRepository : IOurDishRepository
    {
        public Task CreateAsync(OurDish t)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<OurDish?>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<OurDish?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(OurDish t)
        {
            throw new NotImplementedException();
        }
    }
}
