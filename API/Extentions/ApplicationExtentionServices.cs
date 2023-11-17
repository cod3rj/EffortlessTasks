using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Extentions
{
    public static class ApplicationExtentionServices
    {
        public static IServiceCollection AddApplicationService(this IServiceCollection services, IConfiguration config)
        {

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            services.AddDbContext<DataContext>(
                opt =>
                {
                    opt.UseSqlServer(config.GetConnectionString("DefaultConnection"));
                }
            );

            return services;
        }
    }
}