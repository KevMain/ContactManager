﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Castle.Core.Logging;

namespace CompatibleSoftware.Infrastructure.Data
{
    public class Repository<T> : IRepository<T>
    {
        public ILogger Logger { get; set; }

        public Repository()
        {
        }

        #region IRepository<T> Members

        void IRepository<T>.Create(T entity)
        {
            Create(entity);
        }

        void IRepository<T>.Update(T entity)
        {
            Update(entity);
        }

        void IRepository<T>.Delete(T entity)
        {
            Delete(entity);
        }

        T IRepository<T>.Get(int id)
        {
            return Get(id);
        }

        T IRepository<T>.Get(Expression<Func<T, bool>> predicate)
        {
            return Get(predicate);
        }

        int IRepository<T>.Count(Expression<Func<T, bool>> predicate)
        {
            return Count(predicate);
        }

        IEnumerable<T> IRepository<T>.Fetch(Expression<Func<T, bool>> predicate)
        {
            return Fetch(predicate);
        }

        #endregion

        public virtual T Get(int id)
        {
            Logger.Debug(String.Format("Get {0}", id));

            throw new NotImplementedException();
        }

        public virtual T Get(Expression<Func<T, bool>> predicate)
        {
            return Fetch(predicate).SingleOrDefault();
        }

        public virtual void Create(T entity)
        {
            Logger.Debug(String.Format("Create {0}", entity));
        }

        public virtual void Update(T entity)
        {
            Logger.Debug(String.Format("Update {0}", entity));
        }

        public virtual void Delete(T entity)
        {
            Logger.Debug(String.Format("Delete {0}", entity));
        }

        public virtual int Count(Expression<Func<T, bool>> predicate)
        {
            return Fetch(predicate).Count();
        }

        public virtual IQueryable<T> Fetch(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
