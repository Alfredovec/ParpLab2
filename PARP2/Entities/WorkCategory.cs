using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARP2.Entities
{
    public class WorkCategory
    {
        public int WorkCategoryId { get; set; }

        public string Title { get; set; }

        //

        public virtual ICollection<User> Users { get; set; }
    }
}
