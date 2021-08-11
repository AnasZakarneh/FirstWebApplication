using FluentValidation;

namespace FirstWebApplication.Validators
{
    public class ShiftValidator : AbstractValidator<Shift>
    {
        public ShiftValidator()
        {
            RuleFor(shift => shift.EndTime)
                .GreaterThanOrEqualTo(shift => shift.StartTime);
        }
    }
}
