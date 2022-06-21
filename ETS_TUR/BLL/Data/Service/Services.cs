using BLL.Model.Query;
using CORE.Model;
using DOMAIN.Entities;
using DTOS.ActivityDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Data.Service
{
    public interface IServiceCategory : IService<Category>
    {
        Task<ReturnModel<IQueryable<Category>>> ReadAll(QueryModel query);
    }

    public interface IServiceActivity : IService<Activity>
    {
        Task<ReturnModel<Activity>>Insert(ActivityInsertDto dto);
        Task<ReturnModel<Activity>> Update(ActivityUpdateDto dto);
        Task<ReturnModel<IQueryable<Activity>>> ReadAll(QueryModel query);
    }

    public interface IServiceActivityImage : IService<ActivityImage>
    { 
    
    }

    public interface IServiceTicket : IService<Ticket>
    { 
    
    }
}
