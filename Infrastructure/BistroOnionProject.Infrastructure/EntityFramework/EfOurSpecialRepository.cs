using BistroOnionProject.Domain.Entities;
using BistroOnionProject.Infrastructure.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BistroOnionProject.Infrastructure.Persistence.EntityFramework
{
    public class EfOurSpecialRepository : IOurSpecialRepository
    {
        public Task CreateAsync(OurSpecial t)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<OurSpecial?>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<OurSpecial?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(OurSpecial t)
        {
            throw new NotImplementedException();
        }
    }
}
