using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace PARP2.Entities
{
    public class User
    {
        public int UserId { get; set; }

        public string FullName { get; set; }

        public string Email { get; set; }

        public string Gender { get; set; }

        public string Title { get; set; }

        public string Workstation { get; set; }

        public int WorkStatusId { get; set; }

        public int ManagerId { get; set; }

        public int ReporterId { get; set; }

        public int PrimarySkillId { get; set; }

        public string WorkCategoryId { get; set; }

        public int LocationId { get; set; }

        public int UnitId { get; set; }
        
        //

        public virtual WorkStatus WorkStatus { get; set; }

        public virtual Skill PrimarySkill { get; set; }

        public virtual WorkCategory WorkCategory { get; set; }

        public virtual Location Location { get; set; }

        public virtual Unit Unit { get; set; }

        public virtual ICollection<Skill> Skills { get; set; }
            
        public virtual ICollection<Activity> Activities { get; set; }
        
        public virtual ICollection<Role> Roles { get; set; }

        public virtual ICollection<Event> Events { get; set; } 
    }
}
