using Homework3.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework3.Configurations
{
    public class ProjectEntityConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.Property(p => p.CustomerId).IsRequired();
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.NoDays).IsRequired();
        }
    }
}
