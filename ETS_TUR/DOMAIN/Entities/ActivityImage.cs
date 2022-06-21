using CORE.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN.Entities
{
    public class ActivityImage : BaseEntity
    {
        public string Path { get; set; }

        public int ActivityId { get; set; }
        public virtual  Activity Activity { get; set; }
    }
}
