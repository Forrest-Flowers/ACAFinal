using GF.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GF.Data.Interfaces
{
    public interface IUserRepository
    {
        //Create
        User Create(User newUser);

        //Read
        User GetById(string userId);
        //Maybe add FindByGroupId, need to figure out how.

        //Update
        User Update(User updatedUser);

        //Delete
        bool DeleteById(string userId);
    }
}
