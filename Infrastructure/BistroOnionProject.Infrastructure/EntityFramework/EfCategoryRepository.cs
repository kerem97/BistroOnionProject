using BistroOnionProject.Domain.Entities;
using BistroOnionProject.Infrastructure.Persistence.Context;
using BistroOnionProject.Infrastructure.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BistroOnionProject.Infrastructure.Persistence.EntityFramework
{
    public class EfCategoryRepository : ICategoryRepository
    {
        private readonly BistroContext _context;

        public EfCategoryRepository(BistroContext context)
        {
            _context = context;
        }

        public Task CreateAsync(Category t)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Category?>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Category?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Category t)
        {
            throw new NotImplementedException();
        }
    }
}
