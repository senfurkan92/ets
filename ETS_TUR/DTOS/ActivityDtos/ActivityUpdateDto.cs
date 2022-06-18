using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOS.ActivityDtos
{
    public class ActivityUpdateDto : ActivityInsertDto
    {
        public int Id { get; set; }
    }
}
