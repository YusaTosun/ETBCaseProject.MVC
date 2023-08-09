using ETBCaseProject.MVC.Models.CustomerViewModels;
using FluentValidation;

namespace ETBCaseProject.MVC.Validations
{
    public class CustomerCreateVMValidator : AbstractValidator<CustomerCreateVM>
    {
        public CustomerCreateVMValidator()
        {
            RuleFor(x => x.FullName).NotNull().WithMessage("{PropertyName} is required").NotEmpty().WithMessage("{PropertyName} is required");
            RuleFor(x => x.MailAddress).NotNull().WithMessage("{PropertyName} is required").NotEmpty().WithMessage("{PropertyName} is required").EmailAddress().WithMessage("Enter a {PropertyName} in a appropriate format");
            RuleFor(x => x.PhoneNumber).NotNull().WithMessage("{PropertyName} is required").NotEmpty().WithMessage("{PropertyName} is required");
            RuleFor(x => x.BirthDate).NotNull().WithMessage("{PropertyName} is required").NotEmpty().WithMessage("{PropertyName} is required");

        }
    }
}
