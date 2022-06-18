using DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Data.Service
{
    public interface IServiceCategory : IService<Category>
    { 
    
    }

    public interface IServiceActivity : IService<Activity>
    { 
    
    }

    public interface IServiceActivityImage : IService<ActivityImage>
    { 
    
    }

    public interface IServiceTicket : IService<Ticket>
    { 
    
    }
}
