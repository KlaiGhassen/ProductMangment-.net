using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace Domain.Entities
{
    [ComplexType]
   public class Adrress
    {
        public string StreetAddress { get; set; }
        public string City { get; set; }
    }
}
