using SkillTracker.BusinessLayer.Interface;
using SkillTracker.DataLayer;
using SkillTracker.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SkillTracker.BusinessLayer.Service
{
    
    public class UserService : IUserService
    {
        private IUserConnection _userConnection;

        public UserService(UserContext userContext)
        {
            _userConnection = new UserConnection(userContext);
        }
        //Save new user into database
        public async Task<string> CreateNewUser(User user)
        {
            //Business logic to add new user into database
            return null;
        }
        public async Task<string> ValidateUserFirstName(User user)
        {
            //Business logic to validate user name already exist into database before creating new user
            return null;
        }
        //delete user details from database
        public async Task<int> RemoveUser(string firstname, string lastname)
        {
            //Business logic to delete  user from database
            return 0;
        }

        //update user details into database
        public async Task<int> UpdateUser(User user)
        {
            //Business logic to update  user from database
            return 0;
        }
    }
}
