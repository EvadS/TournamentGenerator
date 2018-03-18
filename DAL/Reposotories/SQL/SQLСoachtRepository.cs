using DAL.Abstract;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Reposotories.SQL
{
    public class SQLСoachtRepository : IRepository<Сoach>
    {
        private CompetitorContext db;

        public SQLСoachtRepository()
        {
            this.db = new CompetitorContext();
        }

        public void Create(Сoach item)
        {
            db.Сoaches.Add(item);
        }

        public void Delete(int id)
        {
            Сoach item = db.Сoaches.Find(id);
            if (item != null)
                db.Сoaches.Remove(item);
        }


        public Сoach GetItem(int id)
        {
            return db.Сoaches.Find(id);
        }

        public IEnumerable<Сoach> GetList()
        {
            return db.Сoaches.AsEnumerable();
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Update(Сoach item)
        {
            db.Entry(item).State = EntityState.Modified;
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
