using Homework3.Configurations;
using Homework3.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework3.Data
{
    public sealed class WorkLoadDbContext : DbContext
    {
        public WorkLoadDbContext() { }
        public WorkLoadDbContext(DbContextOptions<WorkLoadDbContext> options) : base(options)
        {

        }
        public DbSet<Freelancer> Freelancer { get; set; }
        public DbSet<Location> Location { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Project> Project { get; set; }
        public DbSet<ProjectAllocation> ProjectAllocation { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FreelancerEntityConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerEntityConfiguration());
            modelBuilder.ApplyConfiguration(new LocationEntityConfiguration());
            modelBuilder.ApplyConfiguration(new ProjectEntityConfiguration());
            modelBuilder.ApplyConfiguration(new ProjectAllocationEntityConfiguration());
        }
    }
}
