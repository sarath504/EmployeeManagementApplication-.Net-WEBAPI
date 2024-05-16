using Concerns.Concerns;
using EmployeeManagement.Service.Services;
using Repository.Repository.Interfaces;
using Service.Services.Constants;
using Service.Services.Interfaces;

namespace Service.Services
{
    public class EmployeeService : IEmployeeService
    {

        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }


        public void AddEmployee(Employee employee)
        {
            _employeeRepository.AddData(ObjectMapper.EmployeeRepositoryData(employee));
        }

        public void DeleteEmployee(string empId)
        {
            _employeeRepository.DeleteData(empId);
        }

        public List<Employee> GetAllEmployees()
        {
            return ObjectMapper.employees(_employeeRepository.LoadData());
        }

        public Employee GetEmployeeById(string empId)
        {
            return ObjectMapper.EmployeeData(_employeeRepository.GetEmployeeById(empId));
        }

        public void UpdateEmployee(Employee employee)
        {
            _employeeRepository.UpdateEmployee(ObjectMapper.EmployeeRepositoryData(employee));
        }

        public void DeleteEmployee()
        {
            List<Employee> employeeData = ObjectMapper.employees(_employeeRepository.LoadData());
            var emp = DeleteEmployeeData(employeeData);
            _employeeRepository.DeleteData(emp);
        }


        public string DeleteEmployeeData(List<Employee> employee)
        {
            Console.Write(Constant.EnterEmployeeIdToDelete);
            var empId = Console.ReadLine();
            var isExists = false;
            foreach (Employee emp in employee)
            {
                if (emp != null)
                {
                    if (emp.Id.Equals(empId))
                    {
                        isExists = true;
                        break;
                    }
                }
            }
            if (!isExists)
            {
                Console.WriteLine(Constant.EmployeeIdIsNotValid);
            }
            else
            {
                Console.WriteLine(Constant.EmployeeDeletedSuccessfully);
            }
            return empId;

        }
    }
}
