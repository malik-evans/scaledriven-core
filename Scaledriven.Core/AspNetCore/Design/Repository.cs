using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Scaledriven.Core.DataAccess;

namespace Scaledriven.Core.AspNetCore.Design
{

    public interface IRepository<T> where T : class
    {
        IEnumerable<T> Get();
        T Get(object key);
        IEnumerable<T> Get(T model);

        T Find(string Id);
    }

    public class Repository<T> : IRepository<T> where T : class
    {

        private readonly DbSet<T> Data;

        public Repository(CoreDbContext dbContext)
        {
            Data = dbContext.Set<T>();
        }

        public IEnumerable<T> Get() => Data.Select(i => i);

        public IEnumerable<T> Get(T model)
        {
            IEnumerable<T> entities = Data.Where(m => m == model);

            if (entities == null)
            {
                throw new Exception($"Entities not found");
            }

            return entities;
        }

        /// TODO Repository.Find
        /// <summary>
        /// Ensures that an Id field exist on the given given generic type
        /// and returns the matching instance
        /// </summary>
        public T Find(string Id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the first entity an object as key
        /// </summary>
        /// <param name="key">The key of the object you are looking for</param>
        /// <returns>An instance of the entity or null</returns>
        public virtual T Get(object key)
        {
            return Data.Find(key);
        }
        /// <summary>
        /// Insert a new entity
        /// </summary>
        /// <param name="entity">Entity you would like to add</param>
        public virtual void Insert(T entity)
        {
            Data.Add(entity);
        }
        /// <summary>
        /// Update entity
        /// </summary>
        /// <param name="entityToUpdate">Entity that you would like to update</param>
        public virtual void Update(T entityToUpdate)
        {
            Data.Attach(entityToUpdate);
        }
        /// <summary>
        /// Delete the entity
        /// </summary>
        /// <param name="entityToDelete">Entity that you wish to delete</param>
        public virtual void Delete(T entityToDelete)
        {
            Data.Remove(entityToDelete);
        }
    }
}
