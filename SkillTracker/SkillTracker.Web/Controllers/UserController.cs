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
        private readonly IUserService _userService;
        public UserController(UserContext userContext)
        {
            _userService = new UserService(userContext);
        }

        [Route("/user/newuser")]
        //Create new user
        public IActionResult NewUser()
        {
            //Business logic
            return View();
        }

        //Create new user
        [HttpPost]
        [Route("/user/newuser")]
        public async Task< IActionResult> NewUser(User user)
        {
            //Business logic to call method of User service entity
            return View();
        }

        //update user details
        [Route("/user/update")]
        public IActionResult ReviseUser()
        {
            //Business logic
            return View();
        }

        //update user details
        [HttpPost]
        [Route("/user/update")]
        public async Task<IActionResult> ReviseUser(User user)
        {
            //Business logic to call method of User service entity
            return View();

        }

        //delete user details
        [Route("/user/delete")]
        public IActionResult DestroyUser()
        {
            //Business logic 
            return View();
        }

        //delete user details
        [HttpPost]
        [Route("/user/delete")]
        public async Task<IActionResult> DestroyUser(String FirstName, String LastName)
        {
            //Business logic to call method of User service entity
            return View();
        }

        
    }
}