using Home_Secuirity_Presistance.DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Home_Secuirity_Presistance
{
    public static class PresistanceServicesRegistratiion
    {
        public static IServiceCollection AddPersistenceServices(
             this IServiceCollection services, IConfiguration configuration)

        {
            services.AddDbContext<HomeSecuirtDataBaseContext>(
                  options => options.UseSqlServer(
                    configuration.GetConnectionString("HomeSecurity")
                    )
                );

           


            return services;
        }



    }
}
