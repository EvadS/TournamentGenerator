using DAL.Abstract;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Reposotories.SQL
{
    public class SQLCategoryRepository : IRepository<Category>
    {

        private CompetitorContext db;

        public SQLCategoryRepository()
        {
            this.db = new CompetitorContext();
           
            // TODO: for test 
            var tt = (SqlConnection)db.Database.Connection; ;
         
        }

        public void Create(Category item)
        {
            db.Categories.Add(item);
        }

        public void Delete(int id)
        {
            Category item = db.Categories.Find(id);
            if (item != null)
                db.Categories.Remove(item);
        }

        public Category GetItem(int id)
        {
            return db.Categories.Find(id);
        }

        public IEnumerable<Category> GetList()
        {
            return db.Categories.AsEnumerable();
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Update(Category item)
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
