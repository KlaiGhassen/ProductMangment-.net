using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;

namespace Service
{
    public class ManageProvider
    {
        private List<Provider> providers;

        public ManageProvider(List<Provider> providers)
        {
            this.providers = providers;
        }
    }
}
