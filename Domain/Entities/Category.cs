using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
  public   class Category
    {

        public int CategoryId   { get; set; }

        public String Name { get; set; }
        IEnumerable<Product> Products { get; set; }


        public Category()
        {
        }
    }
}
