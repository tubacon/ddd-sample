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
            services.AddDbContext<ddd_sampleDbContext>(options => options.UseSqlServer(_configuration.GetConnectionString("DefaultConnection")));

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                endpoints.MapFallbackToFile("index.html");
            });
        }
    }
}
