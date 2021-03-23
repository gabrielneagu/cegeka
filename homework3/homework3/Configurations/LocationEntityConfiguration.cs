using Homework3.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework3.Configurations
{
    public class LocationEntityConfiguration : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> builder)
        {
            builder.Property(l => l.Zipcode).IsRequired();
            builder.Property(l => l.City).IsRequired();
            builder.Property(l => l.State).IsRequired();
            builder.Property(l => l.County).IsRequired();
        }
    }
}
