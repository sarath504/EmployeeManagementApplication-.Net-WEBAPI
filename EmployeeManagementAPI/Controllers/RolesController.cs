using Microsoft.AspNetCore.Http;
using Concerns.Concerns;
using Microsoft.AspNetCore.Mvc;
using Service.Services.Interfaces;

namespace EmployeeManagementAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        private readonly IRolesService _rolesService;
        public RolesController(IRolesService rolesService)
        {
            _rolesService = rolesService;
        }

        [HttpPost]
        public void AddRole(Role role)
        {
            _rolesService.AddRole(role);
        }

        [HttpGet]
        public List<Role> GetAllRoles()
        {
            return _rolesService.GetAllRoles();
        }
    }
}
