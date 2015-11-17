using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARP2.Entities
{
    public class Activity
    {
        public int ActivityId { get; set; }

        public string Title { get; set; }

        public int? ParentActivityId { get; set; }

        //

        public virtual Activity Parent { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
