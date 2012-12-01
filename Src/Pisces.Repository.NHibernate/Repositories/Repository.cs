using System;
using System.Collections.Generic;
using Pisces.Infrastructure.Domain;
using NHibernate;
using Pisces.Repository.NHibernate.SessionStorage;

namespace Pisces.Repository.NHibernate.Repositories
{
    public abstract class Repository<T, TEntityKey>
    {
        public void Add(T entity)
        {
            SessionFactory.GetCurrentSession().Save(entity);
        }

        public void Remove(T entity)
        {
            SessionFactory.GetCurrentSession().Delete(entity);
        }

        public void Save(T entity)
        {
            SessionFactory.GetCurrentSession().SaveOrUpdate(entity);
        }

        public T Get(TEntityKey id)
        {
            return SessionFactory.GetCurrentSession().Get<T>(id);
        }

        public IEnumerable<T> GetAll()
        {
            ICriteria criteriaQuery =
                    SessionFactory.GetCurrentSession().CreateCriteria(typeof(T));

            return (List<T>)criteriaQuery.List<T>();
        }
    }

}
