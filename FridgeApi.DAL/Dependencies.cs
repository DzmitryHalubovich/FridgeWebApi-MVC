using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FridgeManager.DAL
{
    public static class Dependencies
    {
        public static void ConfigureServices(IConfiguration configuration, IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(context => 
                context.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
        }
    }
}
