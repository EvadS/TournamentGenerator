using DAL.Entities;
using SQLite.CodeFirst;
using System.Data.Entity;

namespace TournametGenerator.DAL.DB
{
    public class TournamentContextInitializer : SqliteCreateDatabaseIfNotExists<TournamentContext>
    {

        public TournamentContextInitializer(DbModelBuilder modelBuilder)
            : base(modelBuilder) { }

        protected override void Seed(TournamentContext context)
        {
            context.Set<Category>().Add(new Category() {Age = 1,  WeightFrom =1 ,Sex = 1 , WeightTo = 2});
        }
    }
}
