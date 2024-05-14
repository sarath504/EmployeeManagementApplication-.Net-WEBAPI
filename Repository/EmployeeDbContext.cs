using Microsoft.EntityFrameworkCore;
using EmployeeManagement.Repository.Concerns;

namespace EmployeeManagement.Repository;

public class EmployeeDbContext : DbContext
{

    public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
    {

    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }
    public DbSet<Employee> employeeTable { get; set; }
    public DbSet<Role> RolesTable { get; set; }
}
