using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CompetitorContext : DbContext
    {
        public CompetitorContext()
            : base("CompetitorsConnection")
        {

        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Club> Clubs { get; set; }
        public virtual DbSet<Page> Pages { get; set; }
        public virtual DbSet<Player> Players { get; set; }
        public virtual DbSet<Сoach> Сoaches { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
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
