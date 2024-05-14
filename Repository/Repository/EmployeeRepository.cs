//using Concerns.Concerns;
using EmployeeManagement.Repository;
using EmployeeManagement.Repository.Concerns;
using Repository.Repository.Interfaces;

namespace Repository.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {

        private readonly EmployeeDbContext _employeeDbContext;
        public EmployeeRepository(EmployeeDbContext employeeDbContext)
        {
            _employeeDbContext = employeeDbContext;
        }

        public List<Employee> LoadData()
        {
            var employee = _employeeDbContext.employeeTable;
            return employee.ToList();

        }

        public void AddData(Employee emp)
        {
            if (emp != null)
            {
                _employeeDbContext.employeeTable.Add(emp);
                _employeeDbContext.SaveChanges();
            }
        }

        public void UpdateEmployee(Employee emp)
        {
            if (emp != null)
            {
                _employeeDbContext.employeeTable.Update(emp);
                _employeeDbContext.SaveChanges();
            }
        }

        public void DeleteData(string empId)
        {
            var employee = _employeeDbContext.employeeTable.Where(emp => emp.Id == empId);
            foreach (var emp in employee)
            {
                _employeeDbContext.Remove(emp);
            }
            _employeeDbContext.SaveChanges();
        }

        public Employee GetEmployeeById(string empId)
        {
            var employee = _employeeDbContext.employeeTable.FirstOrDefault(emp => emp.Id == empId);
            if (employee == null)
            {
                return null;
            }
            return employee;
        }
    }
}
