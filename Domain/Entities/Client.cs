using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace Domain.Entities
{
   public class Client
    {
        [Key]
        public int Cin { get; set; }
        public String Prenom { get; set; }
        public String Nom { get; set; }
        public String Email { get; set; }
        public String DateNaissence { get; set; }
        public virtual ICollection<Facture> factures { get; set; }

    }
}
