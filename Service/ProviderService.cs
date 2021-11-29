
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using Data;
using Data.Infrastructure;
using Domain.Entities;
using ServicePattern;


namespace Service
{
    public class ProviderService : EntityService<Provider>, IProviderService
    {
        public ProviderService(IUnitOfWork utwk, IRepositoryBase<Provider> repository) : base(utwk, repository)
        {
        }
    }
}
