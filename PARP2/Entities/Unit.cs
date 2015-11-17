using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARP2.Entities
{
    public class Unit
    {
        public int UnitId { get; set; }

        public string Name { get; set; }

        //

        public virtual ICollection<User> Users { get; set; }
    }
}
