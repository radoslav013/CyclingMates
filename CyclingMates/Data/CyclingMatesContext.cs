using System;
using CyclingMates.Models;
using Microsoft.EntityFrameworkCore;

namespace CyclingMates.Data
{
	public class CyclingMatesContext : DbContext
    {
        public CyclingMatesContext(DbContextOptions<CyclingMatesContext> options) : base(options)
        {
        }

        public DbSet<Activity> Activities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Activity>().ToTable("Activity");
        }
    }
}

