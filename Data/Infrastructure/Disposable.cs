using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Infrastructure
{
    public class Disposable : IDisposable
    {
        //      // Flag for already disposed
         private bool alreadyDisposed;

        // Default Constructor
        ~Disposable()
        {
            Dispose(false);
        }

        // Implementation of IDisposable.
        // Call the virtual Dispose method.
        // Suppress Finalization.

        // Public implementation of Dispose pattern callable by consumers.


        // Protected implementation of Dispose pattern.
        
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this); // Nous appelons SuppressFinalize pour eviter que la methode Dispose soit appele pkusieurs fois
        }
        private void Dispose(bool disposing)
        {
            if (!alreadyDisposed && disposing)
            {
                DisposeCore();
            }
            alreadyDisposed = true;
        }
        protected virtual void DisposeCore()
        {
        }
        
    }
}


