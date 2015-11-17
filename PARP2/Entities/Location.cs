using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARP2.Entities
{
    public class Location
    {
        public int LocationId { get; set; }

        public string Title { get; set; }

        //

        public ICollection<User> Users { get; set; }
    }
}
