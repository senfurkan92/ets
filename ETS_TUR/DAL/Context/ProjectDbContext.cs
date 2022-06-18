using DAL.Map;
using DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
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
            var path = System.IO.Directory.GetCurrentDirectory();
            path = Path.Combine(path, "bin", "Release", "net6.0", "publish", "wwwroot", "db", "EtsProjectDB.db");
            var cstr = $"Data Source={path}";
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
