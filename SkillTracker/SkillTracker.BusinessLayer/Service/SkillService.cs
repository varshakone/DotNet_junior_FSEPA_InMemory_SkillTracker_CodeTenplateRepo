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
    public class SkillService : ISkillService
    {
        private readonly ISkillConnection _skillConnection;

        public SkillService(SkillContext skillContext)
        {
            _skillConnection = new SkillConnection(skillContext);
        }

        // Save new skill upgarded by full stack engineer into database
        public IEnumerable<Skill> GetAllSkills()
        {
            //Business logic to retrieve all skills from database
            return null;
        }
        // Save new skill upgarded by full stack engineer into database
        public async Task<string> AddNewSkill(Skill skill)
        {
            //Business logic to add skills to database
            return null;
        }
        // delete skill of full stack engineer from database
        public async Task<int> DeleteSkill(string skillname)
        {
             //Business logic to delete skill from database
            return 0;
        }
        // update skill upgarded by full stack engineer from database
        public async Task<int> EditSkill(Skill skill)
        {
            //Business logic to update skill from database
            return 0;
        }
    }
}
