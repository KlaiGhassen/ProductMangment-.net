
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
    public class ClientService : EntityService<Client>, IClientService
    {
        public ClientService(IUnitOfWork utwk, IRepositoryBase<Client> repository) : base(utwk, repository)
        {
        }
    }
}
