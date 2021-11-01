using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Configurations
{
    class CategoryConfiguration:IEntityTypeConfiguration<Category>
{
public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.ToTable("MyCategories");
        builder.HasKey(c => c.CategoryId);
            
            //proprety means entity
            builder.Property(p => p.Name)
.IsRequired()
 .HasMaxLength(50);


            //builder.Property(p => p.DateOfBirth)
            //.HasColumnName("DoB")
            //.HasColumnOrder(3)
            //.HasColumnType("datetime2");

            //builder.Property(p => p.StudentName)
            //.IsConcurrencyToken();

        }
    }

    }

