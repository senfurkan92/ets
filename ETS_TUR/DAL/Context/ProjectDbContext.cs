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
            var path = System.IO.Directory.GetCurrentDirectory();
            var cstr = path + "EtsProject.db";
            optionsBuilder.UseSqlite(cstr);
        }
    }
}
