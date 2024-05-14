using EmployeeManagement.Repository.Concerns;
//using Concerns.Concerns;

namespace EmployeeManagement.Service.Services
{
    class ObjectMapper
    {
        public static Concerns.Concerns.Employee EmployeeData(Employee employee)
        {
            if(employee!=null)
            {
                Concerns.Concerns.Employee emp = new Concerns.Concerns.Employee();
                emp.Id = employee.Id;
                emp.FirstName = employee.FirstName;
                emp.LastName = employee.LastName;
                emp.Name = employee.Name;
                emp.JoinDate = employee.JoinDate;
                emp.Location = employee.Location;
                emp.Department = employee.Department;
                emp.Manager = employee.Manager;
                emp.Project = employee.Project;
                emp.Dob = employee.Dob;
                emp.JobTitle = employee.JobTitle;
                emp.EmailId = employee.EmailId;
                emp.Mobile = employee.Mobile;

                return emp;
            }
            return null;
        }

        public static Employee EmployeeRepositoryData(Concerns.Concerns.Employee employee)
        {
            if(employee!= null)
            {
                Employee emp = new Employee();
                emp.Id = employee.Id;
                emp.FirstName = employee.FirstName;
                emp.LastName = employee.LastName;
                emp.Name = employee.Name;
                emp.JoinDate = employee.JoinDate;
                emp.Location = employee.Location;
                emp.Department = employee.Department;
                emp.Manager = employee.Manager;
                emp.Project = employee.Project;
                emp.Dob = employee.Dob;
                emp.JobTitle = employee.JobTitle;
                emp.EmailId = employee.EmailId;
                emp.Mobile = employee.Mobile;

                return emp;
            }
            return null;
        }


        public static Concerns.Concerns.Role RoleData(Role role)
        {
            if (role != null)
            {
                Concerns.Concerns.Role roleData = new Concerns.Concerns.Role();
                roleData.Name = role.Name;
                roleData.Description = role.Description;
                roleData.Department = role.Department;
                roleData.Location = role.Location;
                return roleData;
            }
            return null;
        }

        public static Role RoleRepositoryData(Concerns.Concerns.Role role)
        {
            if (role != null)
            {
                Role roleData = new Role();
                roleData.Name = role.Name;
                roleData.Description = role.Description;
                roleData.Department = role.Department;
                roleData.Location = role.Location;
                return roleData;
            }
            return null;
            
        }


        public static List<Concerns.Concerns.Role> roles(List<EmployeeManagement.Repository.Concerns.Role> role)
        {
            if (role != null)
            {
                List<Concerns.Concerns.Role> rolesList = new List<Concerns.Concerns.Role>();
                foreach (EmployeeManagement.Repository.Concerns.Role roleData in role)
                {
                    rolesList.Add(RoleData(roleData));
                }
                return rolesList;
            }
            return null;
            
        }



        public static List<Concerns.Concerns.Employee> employees(List<EmployeeManagement.Repository.Concerns.Employee> emp)
        {
            if (emp != null)
            {
                List<Concerns.Concerns.Employee> empList = new List<Concerns.Concerns.Employee>();
                foreach (EmployeeManagement.Repository.Concerns.Employee employee in emp)
                {
                    empList.Add(EmployeeData(employee));
                }
                return empList;
            }
            return null;
            
        }

    }
}
