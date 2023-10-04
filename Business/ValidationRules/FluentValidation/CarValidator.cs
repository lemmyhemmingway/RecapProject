using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation;

public class CarValidator: AbstractValidator<Car>
{
    public CarValidator()
    {
        RuleFor(c => c.Name).NotEmpty();
        RuleFor(c => c.Name).MinimumLength(2);
        RuleFor(c => c.Description).NotEmpty();
        RuleFor(c => c.Price).GreaterThan(0);
        RuleFor(c => c.ModelYear).GreaterThan(1900);
        RuleFor(c => c.ModelYear).LessThanOrEqualTo(DateTime.Now.Year);
        RuleFor(c => c.Name).Must(StartWithT);
    }

    private bool StartWithT(string arg)
    {
        return arg.StartsWith("T");
    }
}