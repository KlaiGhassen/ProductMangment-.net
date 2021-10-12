using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;

namespace Service
{
   public static  class ProductExtention
    {
        public static void UpperName(this ManageProduct MP, Product product) {
            product.Name = product.Name.ToUpper();
        
        }
        public static bool InCategory(this ManageProduct MP, Product produt,Category category)
        {
            return produt.MyCategory.Name == category.Name;


        }
    }
}
