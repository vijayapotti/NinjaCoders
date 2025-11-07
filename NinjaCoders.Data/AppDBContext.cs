using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NinjaCoders.Common;

namespace NinjaCoders.Data
{
    // Test comment for Git Change 
    // Another comment for Confirmation
    // Three times is a charm
    public class AppDBContext : DbContext
    {
        //public AppDBContext(DbContextOptions options) : base(options)
        //{
        //}

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = (localdb)\\MSSQLLocalDB; Database = NinjaCoders; Trusted_Connection=True;TrustServerCertificate=True");

        }
    }
}
