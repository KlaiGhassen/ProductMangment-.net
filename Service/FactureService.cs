
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
    public class FactureService : EntityService<Facture>, IFactureService
    {
        public FactureService(IUnitOfWork utwk, IRepositoryBase<Facture> repository) : base(utwk, repository)
        {
        }
    }
}
