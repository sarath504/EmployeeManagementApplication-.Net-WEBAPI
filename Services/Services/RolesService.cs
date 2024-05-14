using Concerns.Concerns;
using EmployeeManagement.Service.Services;
using Repository.Repository.Interfaces;
using Service.Services.Interfaces;

namespace Service.Services
{
    public class RolesService : IRolesService
    {

       private readonly IRolesRepository _rolesRepository;
        public RolesService(IRolesRepository rolesRepository)
        {
            _rolesRepository = rolesRepository;
        }


        public void AddRole(Role role)
        {
            _rolesRepository.AddRole(ObjectMapper.RoleRepositoryData(role));
        }


        public List<Role> GetAllRoles()
        {
            return ObjectMapper.roles(_rolesRepository.LoadData());
        }
    }
}
