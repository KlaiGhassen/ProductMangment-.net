﻿using System;
using System.Collections.Generic;
using Domain.Entities;
using Data;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Data.Infrastructure;
using Service;


namespace Console
    
{
    class Program
    {
        static void Main(string[] args)
        {

            var serviceCollection = new ServiceCollection();
            var seviceProvider = serviceCollection.AddScoped<ICategoryService, CategoryService>()
                                .AddScoped<IProductService, ProductService>()
                .AddScoped<IFactureService,FactureService>()

                .AddScoped<IProviderService,ProviderService>()

                .AddScoped<IClientService,ClientService>()
                .AddTransient<IUnitOfWork, UnitOfWork>()
                .AddTransient(typeof(IRepositoryBase<>), typeof(RepositoryBase<>))
                .AddSingleton<IDatabaseFactory,DatabaseFactory>()
                .AddDbContext<GestionProduitsContext>()
                .BuildServiceProvider();


                

          var serviceCategory= seviceProvider.GetService<ICategoryService>();
            //var category = new Category();
            //category.Name = "Ghassen";
            //serviceCategory.Add(category);
            //serviceCategory.Commit();







            // Creating data base add tables 
            //using (var context = new GestionProduitsContext()) {
            //    context.Database.EnsureDeleted();
            //    context.Database.EnsureCreated();
            //    Product acide = new Product() {
            //        Name = "productName",
            //        Description="ProuctDescription"
            //    };

            //    context.Produts.Add(acide);
            //    context.SaveChanges();



            //}







            //Provider P1 = new Provider(){Password = "12345", ConfirmedPassword = "123456" };

            //System.Console.WriteLine("methode b");
            //Provider.SetIsApproved(P1.Password, P1.ConfirmedPassword, P1.IsAprroved);
            //System.Console.WriteLine("methode a");
            //Provider.SetIsApproved(P1);

            /*** Donnees d'initialisation **/
            //Categories
            //    Category fruit = new Category() { Name = "Fruit" };
            //    Category Alimentaire = new Category() { Name = "Alimentaire" };

            //    //Products
            //    Product acide = new Chemical()
            //    {
            //        DateProd = new DateTime(2000, 12, 12),
            //        Name = "ACIDE CITRIQUE",
            //        Description = "Monohydrate - E330 - USP32",
            //        MyCategory = Alimentaire,
            //        Price = 90,
            //        Quantity = 30,
            //        City = "Sousse"
            //    };
            //    Product cacao = new Chemical()
            //    {
            //        DateProd = new DateTime(2000, 12, 12),
            //        Name = "POUDRE DE CACAO NATURELLE",
            //        Description = "10% -12%",
            //        MyCategory = Alimentaire,
            //        Price = 419,
            //        Quantity = 80,
            //        City = "Sfax"
            //    };

            //    Product dioxyde = new Chemical()
            //    {
            //        DateProd = new DateTime(2000, 12, 12),
            //        Name = "DIOXYDE DE TITANE",
            //        Description = "TiO2 grade alimentaire, cosmétique et pharmaceutique.",
            //        MyCategory = Alimentaire,
            //        Price = 200,
            //        Quantity = 50,
            //        City = "Tunis"
            //    };
            //    Product amidon = new Chemical()
            //    {
            //        DateProd = new DateTime(2000, 12, 12),
            //        Name = "AMIDON DE MAÏS",
            //        Description = "Amidon de maïs natif",
            //        MyCategory = Alimentaire,
            //        Price = 70,
            //        Quantity = 30,
            //        City = "Tunis"
            //    };
            //    Product blackberry = new Biological()
            //    {
            //        DateProd = new DateTime(2000, 12, 12),
            //        Name = "Blackberry",
            //        Description = "",
            //        MyCategory = fruit,
            //        Price = 60,
            //        ProductId = 0,
            //        Quantity = 0

            //    };

            //    Product apple = new Biological()
            //    {
            //        DateProd = new DateTime(2000, 12, 12),
            //        Description = "",
            //        MyCategory = fruit,
            //        Name = "Apple",
            //        Price = 100.00,
            //        ProductId = 0,
            //        Quantity = 100

            //    };

            //    Product avocado = new Biological()
            //    {
            //        DateProd = new DateTime(2000, 12, 12),
            //        Description = "",
            //        MyCategory = fruit,
            //        Name = "Avocado",
            //        Price = 100.00,
            //        ProductId = 0,
            //        Quantity = 100

            //    };

            //    List<Product> products = new List<Product>() { acide, cacao, dioxyde, amidon, blackberry, apple, avocado };
            //    ManageProduct manageProduct = new ManageProduct(products);

            //    Provider sater = new Provider() { Id = 1, UserName = "Medical Provider" };
            //    Provider sudMedical = new Provider() { Id = 2, UserName = "Fruit-SA Provider" };
            //    Provider palliserSa = new Provider() { Id = 3, UserName = "Fruit-CP  Provider" };
            //    Provider prov4 = new Provider() { Id = 4, UserName = "Chemical Med-Provider" };
            //    Provider prov5 = new Provider() { Id = 5, UserName = "Bio Provider" };
            //    List<Provider> providers = new List<Provider>() { sater, sudMedical, palliserSa, prov4, prov5 };
            //    ManageProvider manageProvider = new ManageProvider(providers);

            //    ManageProduct.FindProduct findPrct = delegate (string c) {
            //        foreach (Product product in products) {
            //            if (product.Name.ToUpper().StartsWith(c.ToUpper()))
            //            {

            //             System.Console.WriteLine(  product.Name);

            //            }


            //        }

            //    };

            //    findPrct("a");



        }

        public static void initData(ServiceProvider serviceProvider) {

            Category Alimentaire = new Category()
            
            { Name = "Alimentaire" };
            Provider P1 = new Provider() { Password = "12345", ConfirmedPassword = "123456",
            DateCreated=DateTime.Now,
            Email="ghassen.klai@gmail0com",
            UserName="GhassenKlai"
            };
            Adrress adress = new Adrress()
            {
                City = "sousse",
                StreetAddress = "sousse"
            };
            var client = new Client()
            {
                Cin = 13629722,
                DateNaissence = "25/01/1997",
                Nom = "ghassen",
                Prenom = "klai",

            };
            Product acide = new Chemical()
            {
                DateProd = new DateTime(2000, 12, 12),
                Name = "ACIDE CITRIQUE",
                Description = "Monohydrate - E330 - USP32",
                MyCategory = Alimentaire,
                Price = 90,
                Quantity = 30,
                image = "c:/helloworld",
                MyAdress = adress,
            };


            var facture = new Facture()
            {client=client,
            DateAchat=DateTime.Now,
            prix=50,
                product =acide,

                

            };
          
          
        }

    }
}
