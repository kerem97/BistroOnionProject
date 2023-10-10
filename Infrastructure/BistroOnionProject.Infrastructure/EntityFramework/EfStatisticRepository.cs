using BistroOnionProject.Domain.Entities;
using BistroOnionProject.Infrastructure.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BistroOnionProject.Infrastructure.Persistence.EntityFramework
{
    public class EfStatisticRepository : IStatisticRepository
    {
        public Task CreateAsync(Statistic t)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Statistic?>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Statistic?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Statistic t)
        {
            throw new NotImplementedException();
        }
    }
}
