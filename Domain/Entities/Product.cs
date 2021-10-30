using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
  public  class Product
    {
        [Required(ErrorMessage ="champ name est obligatoire")]
        [StringLength(25,ErrorMessage ="la taille ne peut pas dépasser 25 caractére")]
        [MaxLength(50)]
        public String Name { get; set; }
  
        [DataType(DataType.MultilineText)]
        public String Description { get; set; }

        [Display(Name="Date de production")]
        [DataType(DataType.Date)]
        public DateTime DateProd { get; set; }

      [DataType(DataType.Currency)]
        public double Price { get; set; }

        public int ProductId { get; set; }
        [Range(0,int.MaxValue)]
        public int Quantity { get; set; }
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual  Category MyCategory { get; set; }
        public string image { get; set; }



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
