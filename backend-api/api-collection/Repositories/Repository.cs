using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace api_collection.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public DbContext db;
        public Repository(DbContext db)
        {
            this.db = db;
        }
        public int Count()
        {
            return db.Set<T>().Count();
        }
        public void Create(T entity)
        {
            db.Set<T>().Add(entity);
            db.SaveChanges();
        }
        public void Update(T entity)
        {
            db.Set<T>().Update(entity);
            db.SaveChanges();
        }
        public void Delete(T entity)
        {
            db.Set<T>().Remove(entity);
            db.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return db.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return db.Set<T>().Find(id);
        }  
        public void Save()
        {
            db.SaveChanges();
        } 
    }
}
