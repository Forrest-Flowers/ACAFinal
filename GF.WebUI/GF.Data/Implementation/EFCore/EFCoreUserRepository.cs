using GF.Data.Context;
using GF.Data.Interfaces;
using GF.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GF.Data.Implementation.EFCore
{
    public class EFCoreUserRepository : IUserRepository
    {
        public User Create(User newUser)
        {
            using (var context = new GFDbContext())
            {
                context.Users.Add(newUser);
                context.SaveChanges();

                return newUser;
            }
        }

        public bool DeleteById(string userId)
        {
            using (var context = new GFDbContext())
            {
                var user = GetById(userId);
                context.Remove(user);
                context.SaveChanges();

                if (GetById(userId) == null)
                {
                    return true;
                }
                return false;
            }
        }

        public User GetById(string userId)
        {
            using (var context = new GFDbContext())
            {
                return context.Users.Single(u => u.Id == userId);
            }
        }

        public User Update(User updatedUser)
        {
            using (var context = new GFDbContext())
            {
                var existingUser = GetById(updatedUser.Id);
                context.Entry(existingUser).CurrentValues.SetValues(updatedUser);
                context.SaveChanges();

                return existingUser;
            }
        }
    }
}
