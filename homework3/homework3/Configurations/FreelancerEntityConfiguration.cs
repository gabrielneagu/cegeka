using Homework3.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework3.Configurations
{
    public class FreelancerEntityConfiguration : IEntityTypeConfiguration<Freelancer>
    {
        public void Configure(EntityTypeBuilder<Freelancer> builder)
        {
            builder.Property(f => f.Name).IsRequired();
            builder.Property(f => f.Address).IsRequired();
            builder.Property(f => f.Zipcode).IsRequired();
        }
    }
}
