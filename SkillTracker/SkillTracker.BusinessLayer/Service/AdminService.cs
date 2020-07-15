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
    public class AdminService : IAdminService
    {
        private IUserConnection _userConnection;
        public AdminService(UserContext context)
        {
            _userConnection = new UserConnection(context);
        }
        //return list of all users with pagination
        public async Task<IEnumerable<User>> GetAllUsers()
        {
            //Business logic to retrieve all users from database
            return null;
        }
        //Search user by it's email
        public async Task<User> SearchUserByEmail(string Email)
        {
            //Business logic to search users from database
            return null;
        }
        //Search user by it's first name
        public async Task<User> SearchUserByFirstName(string firstname)
        {
            //Business logic to search users from database
            return null;

        }
        //Search user by it's mobile number
        public async Task<User> SearchUserByMobile(long mobilenumber)
        {
            //Business logic to search users from database
            return null;

        }
        //Search user by it's skill range between start value and end value
        public async Task<User> SearchUserBySkillRange(int startvalue)
        {
            //Business logic to search users from database
            return null;

        }
    }
}
