using FrontToBack.DAL;
using FrontToBack.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FrontToBack.ServicesRegistration
{
    public static class ServiceRegistration
    {
        public static void ServicesRegister(this IServiceCollection services, IConfiguration config)
        {
            services.AddControllersWithViews();
            services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(config.GetConnectionString("DefaultConnection")));
            services.AddScoped<ISum, SumService>();
            services.AddScoped<UserAccount>(s => new UserAccount());

        }
    }
}
