
using BarelyGambling.Core.Entity;
using BarelyGambling.Core.Entity.Enums;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BarelyGambling.Infrastructure
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Team> Teams { get; set; }
        public DbSet<Bidding> Biddings { get; set; }
        public DbSet<TeamMember> TeamMembers { get; set; }
        public DbSet<Tournament> Tournaments { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Like> Likes { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TeamMember>().HasIndex(t => new { t.UserId, t.TeamId }).IsUnique();
            modelBuilder.Entity<Like>().HasIndex(t => new { t.UserId, t.TournamentId }).IsUnique();

            modelBuilder.Entity<TeamMember>()
           .Property(b => b.PlayerType)
           .HasDefaultValue(PlayerType.Member);


        }
    }
}
