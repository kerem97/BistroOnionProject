using BistroOnionProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BistroOnionProject.Infrastructure.Persistence.Context
{
    public class BistroContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=localhost,1433;database=BistroSqlDb;user=sa;password=123456aA*");
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<OurDish> OurDishes { get; set; }
        public DbSet<OurService> OurServices { get; set; }
        public DbSet<OurSpecial> OurSpecials { get; set; }
        public DbSet<Statistic> Statistics { get; set; }
    }
}
