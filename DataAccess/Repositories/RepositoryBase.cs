namespace DataAccess.Repositories
{
    using ProjectDB.Entities;
    using ProjectDB;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;


    public class RepositoryBase<T> : IRepositoryBase<T>
        where T : class
    {
        protected CourseProjectDbContext Context;

        protected DbSet<T> DBSet
        {
            get
            {
                return Context.Set<T>();
            }
        }

        public RepositoryBase() =>
            // this constructor is automatically invoked when the default child constructor is called
            Context = new CourseProjectDbContext();

        public RepositoryBase(CourseProjectDbContext ctx)
        {
            Context = ctx;
        }

        public List<T> GetAll() => Context.Set<T>().ToList();
        public T GetByID(int id) => Context.Set<T>().Find(id);
        public void Create(T item)
        {
            Context.Set<T>().Add(item);
            Context.SaveChanges();
        }
        public void Update(T item, Func<T, bool> findByIDPredecate)
        {
            var local = Context.Set<T>()
                         .Local
                         .FirstOrDefault(findByIDPredecate);// (f => f.ID == item.ID);
            if (local != null)
            {
                Context.Entry(local).State = EntityState.Detached;
            }

            Context.Entry(item).State = EntityState.Modified;

            //    Context.Entry(category).State = EntityState.Modified;
            //var entry = Context.Entry(category);
            //Context.Categories.Attach(category);
            //entry.State = EntityState.Modified;
            Context.SaveChanges();
        }
        public bool DeleteByID(int id)
        {
            bool isDeleted = false;
            T dbItem = Context.Set<T>().Find(id);
            if (dbItem != null)
            {
                Context.Set<T>().Remove(dbItem);
                int recordsChanged = Context.SaveChanges();
                isDeleted = recordsChanged > 0;
            }
            return isDeleted;
        }

        public static implicit operator RepositoryBase<T>(RepositoryBase<Cinema> v)
        {
            throw new NotImplementedException();
        }

    }
}
