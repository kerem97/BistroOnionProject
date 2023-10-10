using BistroOnionProject.Domain.Entities;
using BistroOnionProject.Infrastructure.Persistence.Context;
using BistroOnionProject.Infrastructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BistroOnionProject.Infrastructure.Persistence.EntityFramework
{
    public class EfAboutRepository : IAboutRepository
    {
        private readonly BistroContext _context;

        public EfAboutRepository(BistroContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(About t)
        {
            await _context.Abouts.AddAsync(t);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var value = await _context.Abouts.FindAsync(id);
            _context.Abouts.Remove(value);
            await _context.SaveChangesAsync();

        }

        public async Task<List<About?>> GetAllAsync()
        {
            return await _context.Abouts.ToListAsync();
        }

        public async Task<About?> GetByIdAsync(int id)
        {
            return await _context.Abouts.FirstOrDefaultAsync(x => x.AboutId == id);

        }

        public async Task UpdateAsync(About t)
        {
            _context.Abouts.Update(t);
            await _context.SaveChangesAsync();
        }
    }
}
