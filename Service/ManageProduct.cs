using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using System.Linq;
namespace Service
{
   public class ManageProduct
    {
        private List<Product> products;
        public ManageProduct(List<Product> products)
        {
            this.products = products;
        }
        public delegate void FindProduct(String letter);
        public delegate void ScanProduct(Category categorie);

        public List<Product> GetFiveChemical(double price ) {
            var result = from product in products
                         where (product is Chemical &&  product.Price > price )
                         select (product);
            // change it to list with 5
            return result.Take(5).ToList();

        
        }
        public List<Product> GetProductPrice(double price)
        {
            var result = from product in products
                         where ( product.Price < price)
                         select (product) ;
            // skip 2 an get the list 
            return result.Skip(2).ToList();


        }
        public double GetAveragePrice()
        {
            return (from product in products
                    select (product.Price))
                    .Average();
        }
        public Product GetMaxPrice()
        {
            var maxPrice= (from product in products
                    select (product.Price))
                    .Max();
            var result = from product in products
                         where product.Price == maxPrice
                         select (product);
          //  return result.First();
            return result.FirstOrDefault();

        }
        public int GetCountProduct(string city) {
            var listProduct = from product in products
                              where (product is Chemical && ((Chemical)product).City.Equals(city))
                              select (product);

            return listProduct.ToList().Count();
        }


    }
}
