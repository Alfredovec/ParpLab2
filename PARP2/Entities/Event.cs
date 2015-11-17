using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARP2.Entities
{
    public class Event
    {
        public int EventId { get; set; }

        public int OwnerId { get; set; }

        public int EventTypeId { get; set; }

        public int SkillOrActivityId { get; set; }

        //

        public virtual IEnumerable<User> Subscribers { get; set; }

        public virtual User Owner { get; set; }
    }
}
