using System;
using System.Collections.Generic;
using System.Text;
using Data;
using Data.Infrastructure;
using Domain.Entities;
using ServicePattern;

namespace Service
{
    public class ProviderService : EntityService<Provider>, IproviderService
    {
        public ProviderService(IUnitOfWork _utwk, IRepositoryBase<Provider> _repository) : base(_utwk, _repository)
        {
        }
    }
}
