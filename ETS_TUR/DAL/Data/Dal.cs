using CORE.Data;
using DAL.Context;
using DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data
{
    public class DalCategory : Repo<Category, ProjectDbContext>, IDalCategory
    {
        public DalCategory(ProjectDbContext ctx) : base(ctx)
        {

        }
    }

    public class DalActivity : Repo<Activity, ProjectDbContext>, IDalActivity
    {
        public DalActivity(ProjectDbContext ctx) : base(ctx)
        {

        }
    }

    public class DalActivityImage : Repo<ActivityImage, ProjectDbContext>, IDalActivityImage
    {
        public DalActivityImage(ProjectDbContext ctx) : base(ctx)
        {

        }
    }

    public class DalTicket : Repo<Ticket, ProjectDbContext>, IDalTicket
    {
        public DalTicket(ProjectDbContext ctx) : base(ctx)
        {

        }
    }
}
