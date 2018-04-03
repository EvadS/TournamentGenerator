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
            context.Set<Category>().Add(new Category() { Weight = 20, AgeFrom = 6, Sex = 1, AgeTo = 7, IsBoundary = 0 });
            context.Set<Category>().Add(new Category() { Weight = 25, AgeFrom = 6, Sex = 1, AgeTo = 7, IsBoundary = 1 });
            context.Set<Category>().Add(new Category() { Weight = 30, AgeFrom = 6, Sex = 1, AgeTo = 7, IsBoundary = 2 });
            context.Set<Category>().Add(new Category() { Weight = 30, AgeFrom = 6, Sex = 1, AgeTo = 7, IsBoundary = 3 });
            context.Set<Category>().Add(new Category() { Weight = 25, AgeFrom = 8, Sex = 1, AgeTo = 9, IsBoundary = 4 });
            context.Set<Category>().Add(new Category() { Weight = 30, AgeFrom = 8, Sex = 1, AgeTo = 9, IsBoundary = 5 });
            context.Set<Category>().Add(new Category() { Weight = 35, AgeFrom = 8, Sex = 1, AgeTo = 9, IsBoundary = 6 });
            context.Set<Category>().Add(new Category() { Weight = 40, AgeFrom = 8, Sex = 1, AgeTo = 9, IsBoundary = 7 });
            context.Set<Category>().Add(new Category() { Weight = 40, AgeFrom = 8, Sex = 1, AgeTo = 9, IsBoundary = 8 });
            context.Set<Category>().Add(new Category() { Weight = 30, AgeFrom = 10, Sex = 1, AgeTo = 11, IsBoundary = 9 });
            context.Set<Category>().Add(new Category() { Weight = 35, AgeFrom = 10, Sex = 1, AgeTo = 11, IsBoundary = 10 });
            context.Set<Category>().Add(new Category() { Weight = 40, AgeFrom = 10, Sex = 1, AgeTo = 11, IsBoundary = 11 });
            context.Set<Category>().Add(new Category() { Weight = 45, AgeFrom = 10, Sex = 1, AgeTo = 11, IsBoundary = 12 });
            context.Set<Category>().Add(new Category() { Weight = 45, AgeFrom = 10, Sex = 1, AgeTo = 11, IsBoundary = 13 });
            context.Set<Category>().Add(new Category() { Weight = 35, AgeFrom = 12, Sex = 1, AgeTo = 13, IsBoundary = 14 });
            context.Set<Category>().Add(new Category() { Weight = 40, AgeFrom = 12, Sex = 1, AgeTo = 13, IsBoundary = 15 });
            context.Set<Category>().Add(new Category() { Weight = 45, AgeFrom = 12, Sex = 1, AgeTo = 13, IsBoundary = 16 });
            context.Set<Category>().Add(new Category() { Weight = 50, AgeFrom = 12, Sex = 1, AgeTo = 13, IsBoundary = 17 });
            context.Set<Category>().Add(new Category() { Weight = 50, AgeFrom = 12, Sex = 1, AgeTo = 13, IsBoundary = 18 });
            context.Set<Category>().Add(new Category() { Weight = 45, AgeFrom = 14, Sex = 1, AgeTo = 15, IsBoundary = 19 });
            context.Set<Category>().Add(new Category() { Weight = 50, AgeFrom = 14, Sex = 1, AgeTo = 15, IsBoundary = 20 });
            context.Set<Category>().Add(new Category() { Weight = 55, AgeFrom = 14, Sex = 1, AgeTo = 15, IsBoundary = 21 });
            context.Set<Category>().Add(new Category() { Weight = 60, AgeFrom = 14, Sex = 1, AgeTo = 15, IsBoundary = 22 });
            context.Set<Category>().Add(new Category() { Weight = 60, AgeFrom = 14, Sex = 1, AgeTo = 15, IsBoundary = 23 });
            context.Set<Category>().Add(new Category() { Weight = 60, AgeFrom = 16, Sex = 1, AgeTo = 17, IsBoundary = 24 });
            context.Set<Category>().Add(new Category() { Weight = 65, AgeFrom = 16, Sex = 1, AgeTo = 17, IsBoundary = 25 });
            context.Set<Category>().Add(new Category() { Weight = 70, AgeFrom = 16, Sex = 1, AgeTo = 17, IsBoundary = 26 });
            context.Set<Category>().Add(new Category() { Weight = 75, AgeFrom = 16, Sex = 1, AgeTo = 17, IsBoundary = 27 });
            context.Set<Category>().Add(new Category() { Weight = 75, AgeFrom = 16, Sex = 1, AgeTo = 17, IsBoundary = 28 });
            context.Set<Category>().Add(new Category() { Weight = 70, AgeFrom = 18, Sex = 1, AgeTo = 99, IsBoundary = 29 });
            context.Set<Category>().Add(new Category() { Weight = 80, AgeFrom = 18, Sex = 1, AgeTo = 99, IsBoundary = 30 });
            context.Set<Category>().Add(new Category() { Weight = 90, AgeFrom = 18, Sex = 1, AgeTo = 99, IsBoundary = 31 });
            context.Set<Category>().Add(new Category() { Weight = 90, AgeFrom = 18, Sex = 1, AgeTo = 99, IsBoundary = 32 });
            context.Set<Category>().Add(new Category() { Weight = 20, AgeFrom = 6, Sex = 0, AgeTo = 7, IsBoundary = 33 });
            context.Set<Category>().Add(new Category() { Weight = 25, AgeFrom = 6, Sex = 0, AgeTo = 7, IsBoundary = 34 });
            context.Set<Category>().Add(new Category() { Weight = 30, AgeFrom = 6, Sex = 0, AgeTo = 7, IsBoundary = 35 });
            context.Set<Category>().Add(new Category() { Weight = 30, AgeFrom = 6, Sex = 0, AgeTo = 7, IsBoundary = 36 });
            context.Set<Category>().Add(new Category() { Weight = 25, AgeFrom = 8, Sex = 0, AgeTo = 9, IsBoundary = 37 });
            context.Set<Category>().Add(new Category() { Weight = 30, AgeFrom = 8, Sex = 0, AgeTo = 9, IsBoundary = 38 });
            context.Set<Category>().Add(new Category() { Weight = 35, AgeFrom = 8, Sex = 0, AgeTo = 9, IsBoundary = 39 });
            context.Set<Category>().Add(new Category() { Weight = 35, AgeFrom = 8, Sex = 0, AgeTo = 9, IsBoundary = 40 });
            context.Set<Category>().Add(new Category() { Weight = 30, AgeFrom = 10, Sex = 0, AgeTo = 11, IsBoundary = 41 });
            context.Set<Category>().Add(new Category() { Weight = 35, AgeFrom = 10, Sex = 0, AgeTo = 11, IsBoundary = 42 });
            context.Set<Category>().Add(new Category() { Weight = 40, AgeFrom = 10, Sex = 0, AgeTo = 11, IsBoundary = 43 });
            context.Set<Category>().Add(new Category() { Weight = 40, AgeFrom = 10, Sex = 0, AgeTo = 11, IsBoundary = 44 });
            context.Set<Category>().Add(new Category() { Weight = 35, AgeFrom = 12, Sex = 0, AgeTo = 13, IsBoundary = 45 });
            context.Set<Category>().Add(new Category() { Weight = 40, AgeFrom = 12, Sex = 0, AgeTo = 13, IsBoundary = 46 });
            context.Set<Category>().Add(new Category() { Weight = 45, AgeFrom = 12, Sex = 0, AgeTo = 13, IsBoundary = 47 });
            context.Set<Category>().Add(new Category() { Weight = 45, AgeFrom = 12, Sex = 0, AgeTo = 13, IsBoundary = 48 });
            context.Set<Category>().Add(new Category() { Weight = 45, AgeFrom = 14, Sex = 0, AgeTo = 15, IsBoundary = 49 });
            context.Set<Category>().Add(new Category() { Weight = 50, AgeFrom = 14, Sex = 0, AgeTo = 15, IsBoundary = 50 });
            context.Set<Category>().Add(new Category() { Weight = 55, AgeFrom = 14, Sex = 0, AgeTo = 15, IsBoundary = 51 });
            context.Set<Category>().Add(new Category() { Weight = 55, AgeFrom = 14, Sex = 0, AgeTo = 15, IsBoundary = 52 });
            context.Set<Category>().Add(new Category() { Weight = 50, AgeFrom = 16, Sex = 0, AgeTo = 17, IsBoundary = 53 });
            context.Set<Category>().Add(new Category() { Weight = 55, AgeFrom = 16, Sex = 0, AgeTo = 17, IsBoundary = 54 });
            context.Set<Category>().Add(new Category() { Weight = 60, AgeFrom = 16, Sex = 0, AgeTo = 17, IsBoundary = 55 });
            context.Set<Category>().Add(new Category() { Weight = 60, AgeFrom = 16, Sex = 0, AgeTo = 17, IsBoundary = 56 });
            context.Set<Category>().Add(new Category() { Weight = 55, AgeFrom = 18, Sex = 0, AgeTo = 99, IsBoundary = 57 });
            context.Set<Category>().Add(new Category() { Weight = 65, AgeFrom = 18, Sex = 0, AgeTo = 99, IsBoundary = 58 });
            context.Set<Category>().Add(new Category() { Weight = 65, AgeFrom = 18, Sex = 0, AgeTo = 99, IsBoundary = 59 });
            context.Set<Category>().Add(new Category() { Weight = 0, AgeFrom = 0, Sex = 0, AgeTo = 0, IsBoundary = 60 });

        }
    }
}
