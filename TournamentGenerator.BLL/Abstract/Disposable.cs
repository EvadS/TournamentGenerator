using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournametGenerator.DAL.DB;

namespace BLL.Abstract
{
    public abstract class Disposable : IDisposable
    {
        public TournamentContext db { get; set; }
        private bool disposed = false;


        public Disposable(TournamentContext dataBase)
        {
            db = dataBase;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

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
    }
}
