using DAL.Map;
using DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Context
{
    public class ProjectDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var path = Directory.GetCurrentDirectory();
            var cstr = $"Data Source={path}EtsProject.db";
            optionsBuilder.UseSqlite(cstr);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new ActivityMap());
            modelBuilder.ApplyConfiguration(new ActivityImageMap());
            modelBuilder.ApplyConfiguration(new TicketMap());
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<ActivityImage> ActivityImages { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
    }
}
