using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain.Entities;

namespace Service
{
    public class ManageProvider
    {

        public ManageProvider(List<Provider> providers)
        {
            this.providers = providers;
        }

        public List<Provider> providers;


        public List<Provider>  GetProviderByName(String name) {
        var result = from provider in providers
                     where (provider.UserName.ToUpper().Equals(name.ToUpper()))
                          select (provider);

        return result.ToList();


    }

        public Provider getFirstByName(String name) {
            var result = from provider in providers
                         where (provider.UserName.ToUpper().StartsWith(name.ToUpper()))
                         select (provider);
            return result.First();
        
        
        }
        public Provider GetProvider;



    }

}
