using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using Data.Configurations;
namespace Data
{
    public class GestionProduitsContext : DbContext
    {

      
        protected override void OnConfiguring(DbContextOptionsBuilder  dbContextOptionBuilder)
        {
            dbContextOptionBuilder.UseSqlServer(@"Server=localhost;Database=GestionProduitDb;Trusted_Connection=true;").UseLazyLoadingProxies();
        
        }
        protected override void OnModelCreating(ModelBuilder builder) {
            builder.ApplyConfiguration(new CategoryConfiguration());
            builder.ApplyConfiguration(new ChemichalConfiguration());
            builder.ApplyConfiguration(new FactureConfiguration());
            builder.ApplyConfiguration(new ProductConfiguration());



        }



        //db sets
        public DbSet<Product> Produts { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Chemical> chemicals { get; set; }
        public  DbSet<Biological>  biologicals { get; set; }
        public DbSet<Facture> factures { get; set; }
        public DbSet<Client> clients { get; set; }


        
    }


}
