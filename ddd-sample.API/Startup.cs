using ddd_sample.Application.Interfaces;
using ddd_sample.Application.Mappings;
using ddd_sample.Application.Services;
using ddd_sample.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;

namespace ddd_sample.API
{
    public class Startup
    {
        public IConfiguration _configuration { get; }

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddSwaggerGen();
            services.AddScoped<IDeviceService, DeviceService>();

            //mapper
            services.AddAutoMapper(typeof(MappingProfile));

            //DB
           // services.AddDbContext<ddd_sampleDbContext>(options => options.UseSqlServer(_configuration.GetConnectionString("DefaultConnection")));

        }
    }
}
