using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    class GestionProduitsContext : DbContext
    {
      public void   OnConfiguring() { }
    }
}
