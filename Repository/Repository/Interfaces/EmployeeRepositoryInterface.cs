//using Concerns.Concerns;
using EmployeeManagement.Repository.Concerns;

namespace Repository.Repository.Interfaces
{
    public interface IEmployeeRepository
    {
        public List<Employee> LoadData();

        public void AddData(Employee emp);

        public void UpdateEmployee(Employee emp);

        public Employee GetEmployeeById(string empId);

        public void DeleteData(string empId);
    }
}
