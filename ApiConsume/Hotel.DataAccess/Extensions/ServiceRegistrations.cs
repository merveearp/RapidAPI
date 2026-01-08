using Hotel.DataAccess.Abstract;
using Hotel.DataAccess.Concrete;
using Hotel.DataAccess.Entity_Framework;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DataAccess.Extensions
{
    public static class ServiceRegistrations
    {
        public static void AddRepository(this IServiceCollection services)
        {

            services.AddScoped<ITestimonialDal, EfTestimonialDal>();
            services.AddScoped<ISubscribeDal, EfSubscribeDal>();
            services.AddScoped<IStaffDal, EfStaffDal>();
            services.AddScoped<IRoomDal, EfRoomDal>();
            services.AddScoped<IServiceDal, EfServiceDal>();
        }
    }
}
