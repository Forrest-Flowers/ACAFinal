using GF.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GF.Data.Context
{
    public class GFDbContext : DbContext
    {
        public DbSet<Group> Groups { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<GroupJoinTable> GroupJoinTables { get; set; }
        public DbSet<JoinRequest> JoinRequests { get; set; }
        public DbSet<Planner> Planners { get; set; }
        public DbSet<Date> Dates { get; set; }
        public DbSet<JoinRequestStatus> JoinRequestStatuses { get; set; }


        //Setting up the provider. (SqlServer) and location of Database.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=GF;Trusted_Connection=True");
        }

    }
}
