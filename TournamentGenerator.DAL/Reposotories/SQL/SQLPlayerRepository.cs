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
    public class SQLPlayerRepository : IRepository<Player>
    {
        private CompetitorContext db;

        public SQLPlayerRepository()
        {
            this.db = new CompetitorContext();
        }


        public void Create(Player item)
        {
            db.Players.Add(item);
        }

        public void Delete(int id)
        {
            Player item = db.Players.Find(id);
            if (item != null)
                db.Players.Remove(item);
        }

        public Player GetItem(int id)
        {
            return db.Players.Find(id);
        }

        public IEnumerable<Player> GetList()
        {
            return db.Players.AsEnumerable();
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Update(Player item)
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
