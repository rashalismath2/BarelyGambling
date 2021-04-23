using BarelyGambling.Core.Common;
using BarelyGambling.Core.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BarelyGambling.Infrastructure
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Team> Team { get; set; }
        public DbSet<Bidding> Bidding { get; set; }
        public DbSet<TeamMember> TeamMember { get; set; }
        public DbSet<Tournament> Tournament { get; set; }
        public DbSet<User> User { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<Tournament>()
           .HasMany(c => c.Teams)
           .WithOne(e => e.Tournament);

            string[] names = { "James", "John", "Robert", "Michael", "William", "David", "Richard", "Joseph", "Thomas", "Charles" };
            string[] tournaments = {
                "A1 Grand Prix",
                "Formula One World Championship",
                "FIA World Endurance Championship",
                "FIA GT1 World Championship",
                "World Gliding Championships",
                "FIS Alpine Ski World Cup"
            };


            //creating users
            for (int i = 1; i < 20; i++)
            {
                Random random = new Random();
                int randOne = random.Next(0, names.Length);
                int randTwo = random.Next(0, names.Length);

                var firstName = names[randOne];
                var lastName = names[randTwo];

                modelBuilder.Entity<User>().HasData(new User()
                {
                    Id = Guid.NewGuid(),
                    FirstName = firstName,
                    LastName = lastName,
                    Email = firstName + lastName + i + "@gmail.com",
                    Password = "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S",
                    UserName = firstName + lastName + i
                });
            }
            //creating tournaments
            for (int i = 1; i < tournaments.Length; i++)
            {
                Guid tournamentGuid = Guid.NewGuid();

                Random random = new Random();
                int rand = random.Next(0, 10);
                int randPrice = random.Next(100000, 100000000);

                modelBuilder.Entity<Tournament>().HasData(new Tournament()
                {
                    Id = tournamentGuid,
                    Title = tournaments[i - 1],
                    Description = "Sample description for " + tournaments[i - 1],
                    StartingDate = DateTime.Now.AddDays(rand),
                    TournamentPrize = randPrice
                });

               
                //creating teams for tournamentrs
                for (int j = 1; j < 3; j++)
                {
                    Guid teamGuid = Guid.NewGuid();
                  
                    modelBuilder.Entity<Team>().HasData(new Team()
                    {
                        Id = teamGuid,
                        Title = tournaments[i - 1] + " Team " + j,
                        Description = "Sample description for " + tournaments[i - 1] + " Team " + j,
                        TournamentId = tournamentGuid,
                        Won=j==1?true:false
                    });


                    //creating tournament memebers for team
                    for (int k = 1; k < 3; k++)
                    {
                        modelBuilder.Entity<TeamMember>().HasData(new TeamMember()
                        {
                            Id = Guid.NewGuid(),
                            TeamId = teamGuid,
                            UserId = i
                        });
                    }

                }

  

            }
        }
    }
}
