using BLL.Abstract;
using BLL.Interfaces;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournametGenerator.DAL.Concrete;
using TournametGenerator.DAL.DB;
using ViewModels;

namespace BLL.Concrete
{
    public class CategoryManager : ICategoryManager
    {        
        IGenericRepository<DAL.Entities.Category> categoryRepo;
        private TournamentContext db;
        private bool disposed = false;

        /// <summary>
        /// create manager fow work with category 
        /// </summary>
        /// <param name="dataBase">Database context</param>
        public CategoryManager(TournamentContext dataBase) 
        {
            db = dataBase;
            categoryRepo =new  EFGenericRepository<DAL.Entities.Category>(db); ;
        }

        public bool CreateCategory(Category category)
        {
            throw new NotImplementedException();
        }       

        public List<Category> GetCategories()
        {          
            var list = categoryRepo.GetAll().ToList();

            return list.Select(x => new ViewModels.Category()
            {
                AgeFrom = x.AgeFrom,
                Weight = x.Weight,
                AgeTo = x.AgeTo
            }).ToList();
        }

        public bool RemoveCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public bool UpdateCategory(Category category)
        {
            throw new NotImplementedException();
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
