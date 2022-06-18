using BLL.Data.Service;
using DAL.Data;
using DOMAIN.Entities;

namespace BLL.Data.Manager
{
    public class CategoryManager : ManagerGeneric<Category, IDalCategory>, IServiceCategory
    {
        public CategoryManager(IDalCategory dal) : base(dal)
        {

        }
    }

    public class ActivityManager : ManagerGeneric<Activity, IDalActivity>, IServiceActivity
    {
        public ActivityManager(IDalActivity dal) : base (dal)
        {

        }
    }

    public class ActivityImageManager : ManagerGeneric<ActivityImage, IDalActivityImage>, IServiceActivityImage
    {
        public ActivityImageManager(IDalActivityImage dal) : base(dal)
        {

        }
    }

    public class TicketManager : ManagerGeneric<Ticket, IDalTicket>, IServiceTicket
    {
        public TicketManager(IDalTicket dal) : base(dal)
        {

        }
    }
}
