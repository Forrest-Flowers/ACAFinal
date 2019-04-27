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
        public DbSet<GroupUserLink> GroupUserLinks { get; set; }
        public DbSet<JoinRequest> JoinRequests { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<JoinRequestStatus> JoinRequestStatuses { get; set; }



        //Setting up the provider. (SqlServer) and location of Database.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(Environment.GetEnvironmentVariable("SQLCONNSTR_GROUPFINDER_DB"));

            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=GF;Trusted_Connection=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Make some Roles!
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole { Name = "AppUser", NormalizedName = "APPUSER" },
                new IdentityRole { Name = "SuperUser", NormalizedName = "SUPERUSER" }
                );

            //Seeding for Join Request Responses.
            modelBuilder.Entity<JoinRequestStatus>().HasData(
                new JoinRequestStatus { Id = 1, Description = "New" },
                new JoinRequestStatus { Id = 2, Description = "Pending" },
                new JoinRequestStatus { Id = 3, Description = "Accepted" },
                new JoinRequestStatus { Id = 4, Description = "Denied" }
                );

            //Supposed to properly connect Groups to Users. Don't know if I did this correctly.
            modelBuilder.Entity<GroupUserLink>()
                .HasIndex(x => new { x.GroupId, x.UserId })
                .HasName("IX_GroupUserLink_Group_User");

            modelBuilder.Entity<GroupUserLink>()
            .Property(gu => gu.Id).ValueGeneratedOnAdd();

            modelBuilder.Entity<GroupUserLink>()
            .Property(gu => gu.Id).UseSqlServerIdentityColumn();

            modelBuilder.Entity<GroupUserLink>()
                .HasOne(gu => gu.User)
                .WithMany(u => u.GroupUserLinks)
                .HasForeignKey(gu => gu.UserId);

            modelBuilder.Entity<GroupUserLink>()
                .HasOne(gu => gu.Group)
                .WithMany(g => g.GroupUserLinks)
                .HasForeignKey(gu => gu.GroupId);
        
            modelBuilder.Entity<Event>()
                .HasOne(e => e.Group)
                .WithMany(g => g.Events)
                .HasForeignKey(e => e.GroupId);






        }

    }
}
