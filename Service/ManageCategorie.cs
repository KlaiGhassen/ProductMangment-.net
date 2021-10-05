using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
namespace Service
{
    public class ManageCategorie
    {
        private List<Category> categories;

        public ManageCategorie(List<Category> categories)
        {
            this.categories = categories;
        }
    }
}
