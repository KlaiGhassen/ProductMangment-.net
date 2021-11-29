
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using Data;
using Domain.Entities;
using Data.Infrastructure;
using ServicePattern;



namespace Service
{
    public class ProductService : EntityService<Product>, IProductService
    {
        public ProductService(IUnitOfWork utwk, IRepositoryBase<Product> repository) : base(utwk, repository)
        {
        }

        public List<Product> FindMost5ExpensiveProds()
        {
            return GetMany().OrderByDescending(p => p.Price).Take(5).ToList();
        }


        public float UnavailableProductsPercentage()
        {
            int nbUnavailable =  GetMany(p => p.Quantity == 0).Count();
            int nbProds = GetMany().Count();
            return ((float)nbUnavailable / nbProds) * 100;
        }

        public List<Product> GetProdsByCategorie(Category c)
        {
            var req = GetMany(p => p.MyCategory.Name == c.Name)
                       .ToList();

            return req;
        }

        public void DeleteOldProds()
        {
            var req = GetMany().Where(p => (DateTime.Now - p.DateProd).TotalDays > 365);
            foreach (Product p in req)
                Delete(p);
            Commit();
        }

        public IEnumerable<Product> GetProductByName(string Name)
        {
            return GetMany(m => m.Name.ToString().ToLower().Contains(Name.ToLower()));
        }

        //public void DeleteOldProds()
        //{
        //    DateTime oldDate = DateTime.Now.Subtract(new TimeSpan(365, 0, 0, 0, 0));
        //    var req = GetMany(p => p.DateProd < oldDate);
        //    foreach (Product p in req)
        //        Delete(p);
        //    Commit();
        //}

    }
}
