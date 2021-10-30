using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace Data.Configurations
{
    class ChemichalConfiguration : IEntityTypeConfiguration<Chemical>
    {
        public void Configure(EntityTypeBuilder<Chemical> builder)
        {

            builder.OwnsOne(
                c => c.MyAdress,
                myAdd =>
                {
                    myAdd.Property(a => a.StreetAddress).HasMaxLength(50)
                    .HasColumnName("MyAdress");



                    myAdd.Property(a => a.City).IsRequired()
                    .HasColumnName("MyCity");


                }   

                );
                
               

        }
    }
}
