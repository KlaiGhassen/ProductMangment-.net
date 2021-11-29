
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
    public class CategoryService : EntityService<Category>, ICategoryService
    {
        public CategoryService(IUnitOfWork utwk, IRepositoryBase<Category> repository) : base(utwk, repository)
        {
        }
    }
}
