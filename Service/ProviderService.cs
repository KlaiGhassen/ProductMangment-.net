using System;
using System.Collections.Generic;
using System.Text;
using Data;
using Data.Infrastructure;
using Domain.Entities;
using ServicePattern;

namespace Service
{
    public class FactureService : EntityService<Facture>, IfactureService
    {
        public FactureService(IUnitOfWork _utwk, IRepositoryBase<Facture> _repository) : base(_utwk, _repository)
        {
        }
    }
}
