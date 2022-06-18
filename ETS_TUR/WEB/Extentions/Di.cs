using BLL.Data.Manager;
using BLL.Data.Service;
using DAL.Context;
using DAL.Data;

namespace WEB.Extentions
{
    public static class Di
    {
        public static void AddDi(this IServiceCollection services)
        {
            services.AddDbContext<ProjectDbContext>();

            services.AddScoped<IDalCategory, DalCategory>();
            services.AddScoped<IDalActivity, DalActivity>();
            services.AddScoped<IDalActivityImage, DalActivityImage>();
            services.AddScoped<IDalTicket, DalTicket>();

            services.AddScoped<IServiceCategory, ManagerCategory>();
            services.AddScoped<IServiceActivity, ManagerActivity>();
            services.AddScoped<IServiceActivityImage, ManagerActivityImage>();
            services.AddScoped<IServiceTicket, ManagerTicket>();
        }
    }
}
