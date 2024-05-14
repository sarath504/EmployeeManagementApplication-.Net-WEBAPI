//using Concerns.Concerns;
using EmployeeManagement.Repository.Concerns;

namespace Repository.Repository.Interfaces
{
    public interface IRolesRepository
    {
        public List<Role> LoadData();
        public void AddRole(Role role);

    }
}
