using Hotel.DataAccess.Concrete;
using Hotel.Entity.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System.Reflection;

namespace Hotel.WEBUI.Extensions
{
  
        public static class ServiceRegistrations
        {
            public static void ConfigureService(this IServiceCollection services)
            {
                services.AddDbContext<Context>();
                services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<Context>();
                services.AddAutoMapper(Assembly.GetExecutingAssembly());

            }
        }
    
}
