using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Configurations
{
    class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            //make default table 
            builder.HasMany(prov => prov.Providers).WithMany(prod => prod.Products)
            // custm the table d associastion
            .UsingEntity(
                i => i.ToTable("Product_provider")
                );

            builder.HasOne(Prod => Prod.MyCategory).WithMany(Cat => Cat.Products).OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey(prod => prod.CategoryId);
                
                ;

                


        }
    }
}
