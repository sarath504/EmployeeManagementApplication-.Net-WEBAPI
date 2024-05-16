using FluentValidation;
using Concerns.Concerns;


namespace EmployeeManagement.API.Validations
{
    public class EmployeeValidations:AbstractValidator<Employee>
    {
        public EmployeeValidations()
        {
            RuleFor(employee => employee.Id).NotEmpty()
                .Matches(@"^TZ\d{4}$")
               .WithMessage("Employee Id Format TZ followed by 4 digits eg., TZ0010");

            RuleFor(employee => employee.FirstName).NotEmpty()
                .Matches(@"^[A-Za-z\s]+$")
                .WithMessage("Enter valid first name");

            RuleFor(employee => employee.LastName).NotEmpty()
                .Matches(@"^[A-Za-z\s]+$")
                .WithMessage("Enter valid last name");

            RuleFor(employee => employee.Dob).NotEmpty()
                .WithMessage("Enter valid date of birth");

            RuleFor(employee => employee.EmailId).NotEmpty()
                .EmailAddress()
                .WithMessage("Enter valid email id");

            RuleFor(employee => employee.Mobile).NotEmpty()
                .Matches(@"^[0-9]{10}$")
                .WithMessage("Mobile number must be of 10 digits");

            RuleFor(employee => employee.JoinDate).NotEmpty()
                .WithMessage("Enter valid joining date");

            RuleFor(employee => employee.Location).NotEmpty()
                .WithMessage("Enter valid location");

            RuleFor(employee => employee.Department).NotEmpty()
                .WithMessage("Enter valid department");

            RuleFor(employee => employee.JobTitle).NotEmpty()
                .WithMessage("Enter valid job title");




        }
    }
}
