using DOMAIN.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOS.ActivityDtos
{
    public class ActivityInsertDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string City { get; set; }
        public string PlaceTitle { get; set; }
        public string MapLocation { get; set; }
        public string Address { get; set; }
        public int CategoryId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public IFormFile PosterFile { get; set; }
        public IFormFile[] ImageFiles { get; set; }
        public Ticket[] Tickets { get; set; }
    }
}
