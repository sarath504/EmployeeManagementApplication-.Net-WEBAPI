using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Repository.Concerns
{
    [PrimaryKey(nameof(Name), nameof(Location))]
    public class Role
    {
        public string Name { get; set; }

        public string Department { get; set; }

        public string Description { get; set; }

        public string Location { get; set; }
    }
}
