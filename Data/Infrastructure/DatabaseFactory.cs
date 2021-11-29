using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Data.Infrastructure;
using Microsoft.EntityFrameworkCore;


namespace Data.Infrastructure
{
    public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        private readonly GestionProduitsContext gestionProduitsContext;
        

        public DatabaseFactory(GestionProduitsContext _gestionProduitsContext)
        {
            gestionProduitsContext = _gestionProduitsContext;
        }

        
        public DbContext DataContext
        {
            get { return gestionProduitsContext; }
        }
        
  
        protected override void DisposeCore()
        {
            if (DataContext != null)
                DataContext.Dispose();
        }
        
    }


}
