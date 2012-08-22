using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace CompatibleSoftware.Infrastructure.Data
{
    /// <summary>
    /// Main repository inteface that should be used by all repositories
    /// </summary>
    /// <typeparam name="T">The repository type</typeparam>
    public interface IRepository<T>
    {
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        T Get(int id);
        T Get(Expression<Func<T, bool>> predicate);

        int Count(Expression<Func<T, bool>> predicate);
        IEnumerable<T> Fetch(Expression<Func<T, bool>> predicate);
    }
}
