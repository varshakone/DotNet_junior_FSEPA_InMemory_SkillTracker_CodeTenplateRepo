﻿using SkillTracker.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SkillTracker.BusinessLayer.Interface
{
   public  interface IAdminService
    {
        Task<IEnumerable<User>> GetAllUsers();
        Task<User> SearchUserByFirstName(String firstname);
        Task<User> SearchUserByEmail(String Email);
        Task<User> SearchUserByMobile(long mobilenumber);
        Task<User> SearchUserBySkillRange(int startvalue);

    }
}
