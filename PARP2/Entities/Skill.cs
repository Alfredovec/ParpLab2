using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARP2.Entities
{
    public class Skill
    {
        public int SkillId { get; set; }

        public string Title { get; set; }

        public int YearsOfExperience { get; set; }

        public int LastTimeUsed { get; set; }

        public int CategotyId { get; set; }

        //

        public virtual SkillCategory SkillCategory { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
