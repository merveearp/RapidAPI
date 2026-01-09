using Hotel.Business.Abstract;
using Hotel.Business.Concrete;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Business.Extensions
{
    public static class ServiceRegistrations
    {
        public static void AddService(this IServiceCollection services)
        {
            services.AddScoped<ITestimonialService , TestimonialManager>();
            services.AddScoped<ISubscribeService , SubscribeManager>();
            services.AddScoped<IStaffService , StaffManager>();
            services.AddScoped<IRoomService , RoomManager>();
            services.AddScoped<IServiceService , ServiceManager>();
            services.AddScoped<IAboutService , AboutManager>();
        }
    }
}
