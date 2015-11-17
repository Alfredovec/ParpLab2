using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace PARP2.Entities
{
    public class SkillCategory
    {
        public int SkillCategoryId { get; set; }

        public string Title { get; set; }

        public int? SkillCategoryParentId { get; set; }

        //

        public SkillCategory ParentSkillCategory { get; set; }

        public ICollection<SkillCategory> ChildCategories { get; set; } 
    }
}
