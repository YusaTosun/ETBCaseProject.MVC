using ETBCaseProject.MVC.Models.CustomerViewModels;
using FluentValidation;

namespace ETBCaseProject.MVC.Validations
{
    public class CustomerUpdateVMValidator : AbstractValidator<CustomerUpdateVM>
    {
        public CustomerUpdateVMValidator()
        {
            RuleFor(x => x.FullName).NotNull().WithMessage("{PropertyName} is required").NotEmpty().WithMessage("{PropertyName} is required");
            RuleFor(x => x.MailAddress).NotNull().WithMessage("{PropertyName} is required").NotEmpty().WithMessage("{PropertyName} is required").EmailAddress().WithMessage("Enter a {PropertyName} in a appropriate format");
            RuleFor(x => x.PhoneNumber).NotNull().WithMessage("{PropertyName} is required").NotEmpty().WithMessage("{PropertyName} is required");
            RuleFor(x => x.BirthDate).NotNull().WithMessage("{PropertyName} is required").NotEmpty().WithMessage("{PropertyName} is required");

        }
    }
}
