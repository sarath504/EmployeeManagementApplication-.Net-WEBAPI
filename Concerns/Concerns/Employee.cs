using System.ComponentModel.DataAnnotations;

namespace Concerns.Concerns
{
    public class Employee
    {
        [Required(ErrorMessage ="Enter valid Id"),
         RegularExpression(@"^TZ\d{4}$",ErrorMessage ="Employee Id Format TZ followed by 4 digits eg., TZ0010")]
        public string Id { get; set; }


        [Required(ErrorMessage ="This Field is required")]
        public string FirstName { get; set; }


        [Required(ErrorMessage = "This Field is required")]
        public string LastName { get; set; }


        public string Name { get; set; }


        [Required(ErrorMessage = "This Field is required")]
        public DateTime Dob { get; set; }


        [Required(ErrorMessage = "This Field is required")]
        public string EmailId { get; set; }


        [Required(ErrorMessage = "This Field is required")]
        public string Mobile { get; set; }


        [Required(ErrorMessage = "This Field is required")]
        public DateTime JoinDate { get; set; }


        [Required(ErrorMessage = "This Field is required")]
        public string Location { get; set; }


        [Required(ErrorMessage = "This Field is required")]
        public string JobTitle { get; set; }


        [Required(ErrorMessage = "This Field is required")]
        public string Department { get; set; }

        public string Manager { get; set; }

        public string Project { get; set; }
    }


}
