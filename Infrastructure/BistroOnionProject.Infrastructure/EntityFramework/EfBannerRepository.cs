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
    public class EfBannerRepository : IBannerRepository
    {
        private readonly BistroContext _context;

        public EfBannerRepository(BistroContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(Banner t)
        {
            await _context.Banners.AddAsync(t);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var value = await _context.Banners.FindAsync(id);
            _context.Banners.Remove(value);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Banner?>> GetAllAsync()
        {
            return await _context.Banners.ToListAsync();
        }

        public async Task<Banner?> GetByIdAsync(int id)
        {
            return await _context.Banners.FirstAsync(x => x.BannerId == id);
        }

        public async Task UpdateAsync(Banner t)
        {
            _context.Banners.Update(t);
            await _context.SaveChangesAsync();
        }
    }
}
