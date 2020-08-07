using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SkillTracker.BusinessLayer.Interface;
using SkillTracker.BusinessLayer.Service;
using SkillTracker.DataLayer;
using SkillTracker.Entities;

namespace SkillTracker.Web.Controllers
{
    
    public class UserController : Controller
    {
        /// <summary>
        /// Inject userservice object
        /// </summary>
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }


        /// <summary>
        /// Get : Create new user
        /// </summary>
        /// <returns></returns>
        [Route("User/NewUser")]
        
        public IActionResult NewUser()
        {
            //business logic goes here
            throw new NotImplementedException();
        }


        /// <summary>
        /// Post : Create new user
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        
        [HttpPost]
        [Route("User/NewUser")]
        public async Task< IActionResult> NewUser(User user)
        {
            //business logic goes here
            throw new NotImplementedException();

        }

        /// <summary>
        /// Get : Update User details
        /// </summary>
        /// <returns></returns>
        
        [Route("User/ReviseUser")]
        public IActionResult ReviseUser()
        {
            //business logic goes here
            throw new NotImplementedException();
        }

        /// <summary>
        /// Put : update user details
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        
        [HttpPost]
        [Route("User/ReviseUser")]
        public async Task<IActionResult> ReviseUser(User user)
        {
            //business logic goes here
            throw new NotImplementedException();

        }

        /// <summary>
        /// Get : delete user details
        /// </summary>
        /// <returns></returns>
     
        [Route("User/DestroyUser")]
        public IActionResult DestroyUser()
        {
            //business logic goes here
            throw new NotImplementedException();
        }


        /// <summary>
        /// Delete : delete user details
        /// </summary>
        /// <param name="FirstName"></param>
        /// <param name="LastName"></param>
        /// <returns></returns>
        [Route("User/DestroyUser")]
        [HttpPost]

        public async Task<IActionResult> DestroyUser(String FirstName, String LastName)
        {
            //business logic goes here
            throw new NotImplementedException();
        }

        /// <summary>
        /// Show list of all users with pagination
        /// </summary>
        /// <returns></returns>
        
        [Route("User/allusers")]
        public async Task<IActionResult> AllUsers()
        {
            //business logic goes here
            throw new NotImplementedException();
        }


        /// <summary>
        /// Get : Search user by it's first name
        /// </summary>
        /// <returns></returns>
        
        public IActionResult SearchUser()
        {
            //business logic goes here
            throw new NotImplementedException();
        }


        /// <summary>
        /// Post : Search user by it's first name
        /// </summary>
        /// <returns></returns>
        
        [HttpPost]
        public async Task<IActionResult> InspectUserByFirstName(String FirstName)
        {
            //business logic goes here
            throw new NotImplementedException();
        }


        /// <summary>
        /// Post : Search user by it's email
        /// </summary>
        /// <returns></returns>
       
        [HttpPost]
        public async Task<IActionResult> InspectUserByEmail(String email)
        {
            //business logic goes here
            throw new NotImplementedException();
        }

        /// <summary>
        /// Post : Search user by it's mobile number
        /// </summary>
        /// <returns></returns>
        
        [HttpPost]
        public async Task<IActionResult> InspectUserByMobile(long mobilenumber)
        {
            //business logic goes here
            throw new NotImplementedException();
        }


        /// <summary>
        /// Post : Search user by it's skill range between start value and end value
        /// </summary>
        /// <param name="startvalue"></param>
        /// <param name="endvalue"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> InspectUserBySkillRange(int startvalue,int endvalue)
        {
            //business logic goes here
            throw new NotImplementedException();
        }

        
    }
}