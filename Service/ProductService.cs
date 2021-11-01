using System;
using System.Collections.Generic;
using System.Text;
using Data.Infrastructure;
using Domain.Entities;
using ServicePattern;

namespace Service
{
    class ProductService : EntityService<Product>, IproductService
    {
        public ProductService(IUnitOfWork _utwk, IRepositoryBase<Product> _repository) : base(_utwk, _repository)
        {
        }
    }
}
