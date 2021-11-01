using System;
using System.Collections.Generic;
using System.Text;
using Data;
using Data.Infrastructure;
using Domain.Entities;
using ServicePattern;
namespace Service
{
    public class CategoryService : EntityService<Category>, IcategoryService
    {
        public CategoryService(IUnitOfWork _utwk, IRepositoryBase<Category> _repository) : base(_utwk, _repository)
        {

        }
    }
}
