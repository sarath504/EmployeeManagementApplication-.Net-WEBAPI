using Concerns.Concerns;
using Microsoft.AspNetCore.Mvc;
using Service.Services.Interfaces;

namespace EmployeeManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }


        [HttpGet]
        public List<Employee> GetAllEmployees()
        {
            return _employeeService.GetAllEmployees();
        }


        [HttpGet("Id")]
        public IActionResult GetEmployee(string id)
        {
            if (_employeeService.GetEmployeeById(id) == null)
            {
                return NotFound("Employee not found");
            }
            return Ok(_employeeService.GetEmployeeById(id));
        }


        [HttpPost]
        public IActionResult AddEmployee(Employee emp)
        {
            if (_employeeService.GetEmployeeById(emp.Id) != null)
            {
                return Conflict("Employee exists with this Id");
            }
            _employeeService.AddEmployee(emp);
            return Ok("Employee Added Successfully");
        }



        [HttpDelete("Id")]
        public IActionResult DeleteEmployee(string empId)
        {

            if (_employeeService.GetEmployeeById(empId) == null)
            {
                return NotFound("Employee not found");
            }
            _employeeService.DeleteEmployee(empId);
            return Ok("Employee Deleted Successfully");
        }


        [HttpPut]
        public void UpdateEmployee(Employee emp)
        {
            _employeeService.UpdateEmployee(emp);
        }

    }
}
