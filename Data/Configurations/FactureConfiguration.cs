using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Configurations
{
    public class FactureConfiguration : IEntityTypeConfiguration<Facture>
    {
        public void Configure(EntityTypeBuilder<Facture> builder)
        {
            builder.HasKey(f => new
            {
                f.ProductFk,
                f.ClientFk,
                f.DateAchat

            });
            builder.HasOne(f => f.product).WithMany(prod => prod.factures).HasForeignKey(f=>f.ProductFk);
            builder.HasOne(f => f.client).WithMany(client => client.factures).HasForeignKey(f => f.ClientFk);

        }
    }
}
