using Concerns.Concerns;

namespace Service.Services.Interfaces
{
    public interface IEmployeeService
    {
        public void AddEmployee(Employee emp);
        public void DeleteEmployee();
        public void DeleteEmployee(string empId);
        public void UpdateEmployee(Employee employee);
        public List<Employee> GetAllEmployees();
        public Employee GetEmployeeById(string empId);
    }
}
