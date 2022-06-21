using CORE.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN.Entities
{
    public class Activity : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string City { get; set; }
        public string PlaceTitle { get; set; }
        public string MapLocation { get; set; }
        public string Address { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string PosterPath { get; set; }


        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<ActivityImage> Images { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }

    }
}
