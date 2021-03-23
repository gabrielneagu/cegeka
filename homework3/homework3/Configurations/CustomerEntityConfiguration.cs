using Homework3.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework3.Configurations
{
    public class CustomerEntityConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.Property(c => c.Name).IsRequired();
            builder.Property(c => c.Address).IsRequired();
            builder.Property(c => c.Zipcode).IsRequired();
        }
    }
}
