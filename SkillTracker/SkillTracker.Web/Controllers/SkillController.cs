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
    //[Route("/skill")]
    public class SkillController : Controller
    {
        private readonly ISkillService _skillService;
        public SkillController(ISkillService skillService)
        {
            _skillService = skillService;
        }


        /// <summary>
        /// Show all skills present in db
        /// </summary>
        /// <returns></returns>
          
        
        public async Task<IActionResult> AllSkills()
        {
            //business logic goes here
            throw new NotImplementedException();
        }


        /// <summary>
        /// return view to enter details of skill
        /// </summary>
        /// <returns></returns>

       
        public IActionResult NewSkill()
        {
            //business logic goes here
            throw new NotImplementedException();
        }


        /// <summary>
        /// Post new skill details and save it
        /// </summary>
        /// <param name="skill"></param>
        /// <returns></returns>

       
        [HttpPost]
        public async Task< IActionResult> NewSkill(Skill skill)
        {
            //business logic goes here
            throw new NotImplementedException();
        }

        /// <summary>
        /// Show view to enter details of skill
        /// </summary>
        /// <returns></returns>
        
        [HttpGet]
       
        public IActionResult ReviseSkill()
        {
            //business logic goes here
            throw new NotImplementedException();
        }

        /// <summary>
        /// update skill upgarded by full stack engineer
        /// </summary>
        /// <param name="skill"></param>
        /// <returns></returns>
        
        [HttpPost]
       public async Task<IActionResult> ReviseSkill(Skill skilldetails)
        {
            //business logic goes here
            throw new NotImplementedException();
        }


        /// <summary>
        /// Show view to input name od skill to be deleted
        /// </summary>
        /// <returns></returns>
     
        [HttpGet]
       
        public IActionResult DestroySkill()
        {
            //business logic goes here
            throw new NotImplementedException();
        }


        /// <summary>
        /// delete skill of full stack engineer
        /// </summary>
        /// <param name="skillname"></param>
        /// <returns></returns>
        
        [HttpPost]
    
        public async Task<IActionResult> DestroySkill(String skillname)
        {
            //business logic goes here
            throw new NotImplementedException();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}