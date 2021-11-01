using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace ServicePattern
{

    public interface IEntityService<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        void Delete(Expression<Func<TEntity, bool>> where);
        TEntity GetById(int id);
        TEntity GetById(string id);
        IEnumerable<TEntity> GetMany(Expression<Func<TEntity, bool>> where = null);
        TEntity Get(Expression<Func<TEntity, bool>> where);
        void Commit();


    }
}
