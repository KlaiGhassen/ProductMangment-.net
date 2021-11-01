using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Infrastructure;
using System.Linq.Expressions;


namespace ServicePattern
{
    public abstract class EntityService<TEntity> : IEntityService<TEntity> where TEntity : class
    {
    
        private readonly IUnitOfWork utwk;
        private readonly IRepositoryBase<TEntity> repository;

        public EntityService(IUnitOfWork _utwk, IRepositoryBase<TEntity> _repository)
        {
            this.utwk = _utwk;
            this.repository = _repository;

        }

        public virtual void Add(TEntity entity)
        {
            repository.Add(entity);
        }
        public virtual void Update(TEntity entity)
        {
            repository.Update(entity);
        }
        public virtual void Delete(TEntity entity)
        {
            repository.Delete(entity);
        }
        public virtual void Delete(Expression<Func<TEntity, bool>> where)
        {
            repository.Delete(where);
        }
        public virtual TEntity GetById(int id)
        {
            return repository.GetById(id);
        }
        public virtual TEntity GetById(string id)
        {
            return repository.GetById(id);
        }
        public virtual IEnumerable<TEntity> GetMany(Expression<Func<TEntity, bool>> filter = null)
        {
            return repository.GetMany(filter);
        }
        public virtual TEntity Get(Expression<Func<TEntity, bool>> where)
        {
            return repository.Get(where);
        }
        public virtual void Dispose()
        {
            utwk.Dispose();
        }
        public void Commit()
        {
            try
            {
                utwk.Commit();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
