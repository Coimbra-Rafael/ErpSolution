using ErpSolution.Domain.Entities;

using FluentValidation;

namespace ErpSolution.Domain.Validations;

public class CustomerValidation : AbstractValidator<Customer>
{
    public CustomerValidation()
    {
        RuleFor(c => c.Name)
             .NotEmpty().WithMessage("Name is required.")
             .Length(2, 150).WithMessage("Name must be between 2 and 100 characters.");

        RuleFor(c => c.Email)
            .NotEmpty().WithMessage("Email is required.")
            .EmailAddress().WithMessage("Invalid email format.");

        RuleFor(c => c.Phone)
            .NotEmpty().WithMessage("Phone number is required.")
            .Matches(@"^\+?[1-9]\d{1,14}$").WithMessage("Invalid phone number format.");

        RuleFor(c => c.Active)
            .NotNull().WithMessage("Active status is required.");
    }
}