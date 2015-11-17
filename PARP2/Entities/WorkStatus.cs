using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARP2.Entities
{
    public class WorkStatus
    {
        public int WorkStatusId { get; set; }

        public string WorkStatusTitle { get; set; }

        //

        public virtual ICollection<User> Users { get; set; }
    }
}
