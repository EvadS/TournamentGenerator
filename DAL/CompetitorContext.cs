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
        public virtual DbSet<Phase> Phases { get; set; }
        public virtual DbSet<Player> Players { get; set; }
        public virtual DbSet<Position> Positions { get; set; }
        public virtual DbSet<Сoach> Сoaches { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany(e => e.Pages)
                .WithRequired(e => e.Category)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Club>()
                .HasMany(e => e.Players)
                .WithRequired(e => e.Club)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Page>()
                .HasMany(e => e.Players)
                .WithMany(e => e.Pages)
                .Map(m => m.ToTable("PlayerPage").MapLeftKey("PageID").MapRightKey("PlayerID"));

            modelBuilder.Entity<Phase>()
                .HasMany(e => e.Players)
                .WithMany(e => e.Phases)
                .Map(m => m.ToTable("PlayerPhase").MapLeftKey("PhaseId").MapRightKey("PlayerId"));

            modelBuilder.Entity<Player>()
                .HasMany(e => e.Positions)
                .WithMany(e => e.Players)
                .Map(m => m.ToTable("PlayerPosition").MapLeftKey("PlayerID").MapRightKey("PositionID"));

            modelBuilder.Entity<Сoach>()
                .HasMany(e => e.Players)
                .WithRequired(e => e.Сoach)
                .WillCascadeOnDelete(false);
        }

    }
}
