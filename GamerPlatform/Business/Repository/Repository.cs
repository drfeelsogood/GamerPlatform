using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Data.Entity;
using Data.Context;

namespace Business.Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity, new()
    {
        protected DbContext _entities;
        protected readonly IDbSet<T> _dbset;

        public Repository()
        {

            _entities = new YorGameContext();
            _dbset = _entities.Set<T>();
        }

        public virtual IEnumerable<T> GetAll()
        {

            return _dbset.AsEnumerable<T>();
        }

        public virtual T FindByID(int? id)
        {
            return _dbset.Find(id);
        }

        public IEnumerable<T> FindBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {

            IEnumerable<T> query = _dbset.Where(predicate).AsEnumerable();
            return query;
        }

        public virtual T Add(T entity)
        {
            return _dbset.Add(entity);
        }

        public virtual T Delete(T entity)
        {
            return _dbset.Remove(entity);
        }

        public virtual void Edit(T entity)
        {
            _entities.Entry(entity).State = System.Data.Entity.EntityState.Modified;
        }

        public virtual void Save()
        {
            _entities.SaveChanges();
        }
    }
}
