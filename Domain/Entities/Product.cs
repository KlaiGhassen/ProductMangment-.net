using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
  public  class Product
    {
        public DateTime DateProd { get; set; }
        public String Description { get; set; }

        public String Name { get; set; }
        public double Price { get; set; }

        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public virtual  Category MyCategory { get; set; }

     public virtual ICollection<Provider> Providers { get; set; }

        public Product() { }

        public override string ToString()
        {
            return base.ToString();
        }

        //public override void GetDetails()
        //{

        //    Console.WriteLine("DateProd :"+ DateProd+ "Description "+ Description, "Name", Name, "Price", Price, "ProductId", ProductId, "Quantity", Quantity);
        //}
    }
}
