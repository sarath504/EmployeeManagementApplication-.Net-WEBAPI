using FluentValidation;
using Concerns.Concerns;

namespace EmployeeManagement.API.Validations
{
    public class RoleValidations : AbstractValidator<Role>
    {
        public RoleValidations()
        {
            RuleFor(role => role.Name).NotEmpty()
                .Matches(@"^[A-Za-z\s]+$")
                .WithMessage("Enter valid role name");

            RuleFor(role => role.Location).NotEmpty()
                .Matches(@"^[A-Za-z\s]+$")
                .WithMessage("Enter valid location");

            RuleFor(role => role.Department).NotEmpty()
                .Matches(@"^[A-Za-z\s]+$")
                .WithMessage("Enter valid department");
        }
    }
}
