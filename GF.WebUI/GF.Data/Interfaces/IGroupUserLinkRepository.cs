using GF.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GF.Data.Interfaces
{
    public interface IGroupUserLinkRepository
    {
        //Create
        GroupUserLink Create(GroupUserLink newGroupUserLink);

        //Read
        GroupUserLink GetById(int Id);
        ICollection<GroupUserLink> GetByGroupId(int groupId);
        ICollection<GroupUserLink> GetByUserId(string userId);

        //Update
        GroupUserLink Update(GroupUserLink updatedGroupUserLink);

        //Delete
        bool DeleteById(int Id);

    }
}
