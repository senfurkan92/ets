using CORE.Data;
using DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data
{
    public interface IDalCategory : IRepo<Category>
    { 
    
    }

    public interface IDalActivity : IRepo<Activity>
    {

    }

    public interface IDalActivityImage : IRepo<ActivityImage>
    {

    }

    public interface IDalTicket : IRepo<Ticket>
    {

    }
}
