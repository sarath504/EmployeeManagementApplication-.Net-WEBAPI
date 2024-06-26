using EmployeeManagement.Repository;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using Repository.Repository;
using Repository.Repository.Interfaces;
using Service.Services;
using Service.Services.Interfaces;
using System.Reflection;

namespace EmployeeManagementAPI
{
    public class Program
    {

        public static void Main(string[] args)
        {

            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            builder.Services.AddTransient<IEmployeeService, EmployeeService>();
            builder.Services.AddTransient<IRolesService, RolesService>();
            builder.Services.AddScoped<IRolesRepository, RolesRepository>();

            builder.Services.AddDbContext<EmployeeDbContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("database")));

            builder.Services.AddControllers()
            .AddFluentValidation(v =>
            {
                v.ImplicitlyValidateChildProperties = true;
                v.ImplicitlyValidateRootCollectionElements = true;
                v.RegisterValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            });

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
