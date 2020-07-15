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
    public class SkillController : Controller
    {
        private readonly ISkillService _skillService;
        public SkillController(SkillContext skillContext)
        {
            _skillService = new SkillService(skillContext);
        }
        // Save new skill upgarded by full stack engineer
        public IActionResult AllSkills()
        {
            //Business logic to call method of Skill service entity
            return View();
        }
        // Save new skill upgarded by full stack engineer
        public IActionResult NewSkill()
        {
            //Business logic to call method of Skill service entity
            return View();
        }

        // Save new skill upgarded by full stack engineer
        [HttpPost]
        public async Task< IActionResult> NewSkill(Skill skill)
        {
            //Business logic to call method of Skill service entity
            return View();
        }

        // update skill upgarded by full stack engineer
        [HttpGet]
        [Route("/skill/update")]
        public IActionResult ReviseSkill()
        {
            //Business logic to call method of Skill service entity
            return View();
        }

        // update skill upgarded by full stack engineer
        [HttpPost]
        [Route("/skill/update")]
        public async Task<IActionResult> ReviseSkill(Skill skill)
        {
            //Business logic to call method of Skill service entity
            return View();
        }

        // delete skill of full stack engineer
        [HttpGet]
        [Route("/skill/delete")]
        public IActionResult DestroySkill()
        {
            //Business logic to call method of Skill service entity
            return View();
        }

        // delete skill of full stack engineer
        [HttpPost]
        [Route("/skill/delete")]
        public async Task<IActionResult> DestroySkill(String skillname)
        {
            //Business logic to call method of Skill service entity
            return View();
        }

        
    }
}