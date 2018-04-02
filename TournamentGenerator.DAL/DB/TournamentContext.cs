using DAL.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace TournametGenerator.DAL.DB
{
    public class TournamentContext : DbContext
    {

        public TournamentContext (): base("tournamentDB")
        {
           
        }

        public  DbSet<Category> Categories { get; set; }
        //public  DbSet<Club> Clubs { get; set; }
        //public  DbSet<Page> Pages { get; set; }
        //public  DbSet<Player> Players { get; set; }
        //public  DbSet<Сoach> Сoaches { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var contextinitialiser = new TournamentContextInitializer(modelBuilder);
            Database.SetInitializer(contextinitialiser);
        }
    }
}
