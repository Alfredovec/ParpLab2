using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARP2.Entities
{
    class Activity
    {
        public int ActivityId { get; set; }

        public string Title { get; set; }

        public int? ParentActivityId { get; set; }

        //

        public Activity Parent { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
