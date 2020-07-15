using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SkillTracker.BusinessLayer.Interface;
using SkillTracker.BusinessLayer.Service;
using SkillTracker.DataLayer;
using SkillTracker.Web.Models;

namespace SkillTracker.Web.Controllers
{
    public class AdminController : Controller
    {
        private readonly IAdminService _adminService;
        public AdminController(UserContext userContext)
        {
            _adminService = new AdminService(userContext);
        }
        //Show list of all users with pagination
        [Route("/admin/allusers")]
        public async Task< IActionResult> AllUsers()
        {
            //Business logic to call all users method of admin service entity
            return View();
        }

        //Search user by it's first name
        public IActionResult SearchUser()
        {
            //Business logic to render search user view.
            return View();
        }
      
        //Search user by it's first name
        [HttpPost]
        public async Task<IActionResult> InspectUserByFirstName(String FirstName)
        {
            //Business logic to call method of admin service entity
            return View();
        }

       

        //Search user by it's email
        [HttpPost]
        public async Task< IActionResult> InspectUserByEmail(String email)
        {
            //Business logic to call method of admin service entity
            return View();
        }

       
        //Search user by it's mobile number
        [HttpPost]
        public async Task< IActionResult> InspectUserByMobile(long mobilenumber)
        {
            //Business logic to call method of admin service entity
            return View();
        }

      
        //Search user by it's skill range between start value and end value
        [HttpPost]
        public async  Task<IActionResult> InspectUserBySkillRange(int start)
        {
            //Business logic to call method of admin service entity
            return View();
        }
        

        

       
    }
}
