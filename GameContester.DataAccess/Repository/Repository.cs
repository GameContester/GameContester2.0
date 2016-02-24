using System.Collections.Generic;
using System.Data.Entity;
using GameContester.Contracts.Repositories;
using GameContester.Domain.Entities;

namespace GameContester.DataAccess.Repository
{
  public  class Repository<T, TKey> : IRepository<T, TKey> where T : class, IEntity<TKey>
    {
        public Repository(GameContesterDBContext context)
        {
            this.Context = context;
        }

        protected readonly GameContesterDBContext Context;

        protected internal DbSet<T> Entities
        {
            get { return Context.Set<T>(); }
        }

        public void Add(T entity)
        {
            this.Entities.Add(entity);
            this.Context.SaveChanges();
        }

        public void Delete(TKey id)
        {
            var entity = Find(id);
            this.Entities.Remove(entity);
            this.Context.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return this.Entities;
        }

        public T Find(TKey id)
        {
            return this.Entities.Find(id);
        }

        public void Update(T entity)
        {
            this.Context.Entry(entity).State = EntityState.Modified;
            this.Context.SaveChanges();
        }
    }
}
