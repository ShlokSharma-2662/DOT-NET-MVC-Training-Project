using CarAPI.Common.Models;
using CarAPI.WebApp._4_Repository.Entity;
using CarAPI.WebApp._4_Repository.EntityConfiguration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAPI.WebApp._4_Repository
{
    public class Context : DbContext
    {

        public Context(DbContextOptions options) : base(options) { }

        public DbSet<CarEntity>? CarDBSet { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          //modelBuilder.Entity<Car>().ToTable("CarDataStore");
            modelBuilder.Entity<CarEntity>().ToTable("CarDataStore");
            modelBuilder.ApplyConfiguration(new CarConfiguration());
        }

    }
}
