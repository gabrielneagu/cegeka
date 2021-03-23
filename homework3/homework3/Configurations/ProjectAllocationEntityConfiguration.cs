using Homework3.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework3.Configurations
{
    public class ProjectAllocationEntityConfiguration : IEntityTypeConfiguration<ProjectAllocation>
    {
        public void Configure(EntityTypeBuilder<ProjectAllocation> builder)
        {
            builder.Property(pa => pa.FreelancerId).IsRequired();
            builder.Property(pa => pa.ProjectId).IsRequired();
            builder.Property(pa => pa.WorkDay).IsRequired();
            builder.Property(pa => pa.PricePerHour).IsRequired();
            builder.Property(pa => pa.NoHours).IsRequired();
        }
    }
}
