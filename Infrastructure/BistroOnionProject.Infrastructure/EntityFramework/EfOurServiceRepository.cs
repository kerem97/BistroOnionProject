using BistroOnionProject.Domain.Entities;
using BistroOnionProject.Infrastructure.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BistroOnionProject.Infrastructure.Persistence.EntityFramework
{
    public class EfOurServiceRepository : IOurServiceRepository
    {
        public Task CreateAsync(OurService t)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<OurService?>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<OurService?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(OurService t)
        {
            throw new NotImplementedException();
        }
    }
}
