using FluentValidation;

namespace FirstWebApplication.Validators
{
    public class ShiftValidator : AbstractValidator<Shift>, IShiftValidator
    {
        public ShiftValidator()
        {
            RuleFor(shift => shift.EndTime)
                .GreaterThanOrEqualTo(shift => shift.StartTime);
        }
    }
}
