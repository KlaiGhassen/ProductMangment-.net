using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;

namespace Data
{
    public class GestionProduitsContext : DbContext
    {

      
        protected override void OnConfiguring(DbContextOptionsBuilder  dbContextOptionBuilder)
        {
            dbContextOptionBuilder.UseSqlServer(@"Server=localhost;Database=GestionProduitDb;Trusted_Connection=true;").UseLazyLoadingProxies();
        
        }

        public DbSet<Product> Produts { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Chemical> chemicals { get; set; }
        public  DbSet<Biological>  biologicals { get; set; }


    }
}
