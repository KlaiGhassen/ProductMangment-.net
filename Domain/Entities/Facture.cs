using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
  public  class Facture
    {
        public int ProductFk { get; set; }
        public virtual Product product { get; set; }
        public int ClientFk { get; set; }
        public virtual Client client { get; set; }
        public DateTime DateAchat { get; set; }
        public float prix { get; set; }
    }
}
