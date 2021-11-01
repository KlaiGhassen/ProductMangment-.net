using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Microsoft.EntityFrameworkCore;


namespace Data.Infrastructure
{
    public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        private DbContext dataContext;
        public DbContext DataContext
        {
            get { return dataContext; }
        }
        public DatabaseFactory() { dataContext = new GestionProduitsContext(); }
        protected override void DisposeCore()
        {
            if (dataContext != null)
                dataContext.Dispose();
        }
        
    }


}
