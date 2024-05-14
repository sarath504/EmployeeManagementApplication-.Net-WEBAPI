using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Repository.Concerns;
using Repository.Repository;
using Repository.Repository.Interfaces;
using Service.Services;
using Service.Services.Interfaces;

namespace EmployeeDirectoryApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            var services = new ServiceCollection();
            services.AddTransient<IEmployeeRepository, EmployeeRepository>();
            services.AddTransient<IEmployeeService, EmployeeService>();
            services.AddTransient<IEmployeeManagementMenu, EmployeeManagementMenu>();
            services.AddTransient<IRolesService, RolesService>();
            services.AddTransient<IRolesRepository, RolesRepository>();

            services.AddDbContext<EmployeeDbContext>(options =>
            options.UseSqlServer("server=10.0.0.27;database=Sarath_DB;trusted_connection=True;encrypt=False;"));

            services.AddDbContext<RoleDbContext>(options =>
            options.UseSqlServer("server=10.0.0.27;database=Sarath_DB;trusted_connection=True;encrypt=False;"));

            var serviceProvider = services.BuildServiceProvider();
            var service = serviceProvider.GetRequiredService<IEmployeeManagementMenu>();
            service.EmployeeDirectory();
        }
    }
}
