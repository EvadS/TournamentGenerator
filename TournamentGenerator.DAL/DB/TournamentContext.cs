using DAL.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace TournametGenerator.DAL.DB
{
    public class TournamentContext : DbContext
    {

        public TournamentContext() : base("tournamentDB")
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Club> Clubs { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Сoach> Сoaches { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var contextinitialiser = new TournamentContextInitializer(modelBuilder);
            Database.SetInitializer(contextinitialiser);

            modelBuilder.Entity<Category>()
               .HasMany(e => e.Players)
               .WithMany(e => e.Categories)
               .Map(m => m.ToTable("CategoryPlayer").MapLeftKey("CategoryId").MapRightKey("PlayerID"));

            modelBuilder.Entity<Page>()
                .HasMany(e => e.Players)
                .WithMany(e => e.Pages)
                .Map(m => m.ToTable("PlayerPage").MapLeftKey("PageId").MapRightKey("PlayerId"));

            modelBuilder.Entity<Player>()
                .HasMany(e => e.Сoach)
                .WithMany(e => e.Players)
                .Map(m => m.ToTable("CoachPlayer").MapLeftKey("PlayerId").MapRightKey("CoachId"));

        }
    }
}
