using GF.Domain.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GF.Data.Context
{
    public class GFDbContext : IdentityDbContext<User>
    {
        public DbSet<Group> Groups { get; set; }
        public DbSet<GroupUserLink> GroupJoinLinks { get; set; }
        public DbSet<JoinRequest> JoinRequests { get; set; }
        public DbSet<Planner> Planners { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<JoinRequestStatus> JoinRequestStatuses { get; set; }


        //Setting up the provider. (SqlServer) and location of Database.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=GF;Trusted_Connection=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole { Name = "User", NormalizedName = "USER"},
                new IdentityRole { Name = "Admin", NormalizedName = "ADMIN"}
                );

            modelBuilder.Entity<JoinRequestStatus>().HasData(
                new JoinRequestStatus { Id = 1, Description = "New" },
                new JoinRequestStatus { Id = 2, Description = "Pending" },
                new JoinRequestStatus { Id = 3, Description = "Accepted" },
                new JoinRequestStatus { Id = 4, Description = "Denied" }
                );

            modelBuilder.Entity<GroupUserLink>()
                .HasKey(x => new { x.GroupId, x.UserId });
        }

    }
}
