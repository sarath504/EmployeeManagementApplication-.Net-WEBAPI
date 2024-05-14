//using Concerns.Concerns;
using EmployeeManagement.Repository;
using EmployeeManagement.Repository.Concerns;
using Newtonsoft.Json;
using Repository.Repository.Interfaces;

namespace Repository.Repository
{

    public class RolesRepository : IRolesRepository
    {
        private readonly EmployeeDbContext _employeeDbContext;
        public RolesRepository(EmployeeDbContext employeeDbContext)
        {
            _employeeDbContext = employeeDbContext;
        }
        public List<Role> LoadData()
        {
            var rolesList = _employeeDbContext.RolesTable.ToList();
            return rolesList;
        }

        public void AddRole(Role role)
        {
            _employeeDbContext.RolesTable.Add(role);
            _employeeDbContext.SaveChanges();
        }


        #region Helpers
        private void JsonSerialize(List<Role> list)
        {
            string json = JsonConvert.SerializeObject(list);
            File.WriteAllText("RolesDetails.json", json);
        }

        private List<Role> JsonDeserialize()
        {
            List<Role> roles = JsonConvert.DeserializeObject<List<Role>>(File.ReadAllText(@"./RolesDetails.json"));
            return roles;
        }
        #endregion
    }
}
