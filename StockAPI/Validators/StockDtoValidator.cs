using FluentValidation;
using StockAPI.Dtos;

namespace StockAPI.Validators
{
    public class StockDtoValidator : AbstractValidator<StockDto>
    {
        public StockDtoValidator()
        {
            RuleFor(x => x.ProductCode).NotNull().WithMessage("{PropertyName} is Required").NotEmpty().WithMessage("{PropertyName} is Required");

            RuleFor(x => x.VariantCode).NotNull().WithMessage("{PropertyName} is Required").NotEmpty().WithMessage("{PropertyName} is Required");

            RuleFor(x => x.Quantity).NotNull().WithMessage("{PropertyName} is Required").NotEmpty().WithMessage("{PropertyName} is Required");
      
            RuleFor(x => x.Quantity).InclusiveBetween(1, int.MaxValue).WithMessage("{PropertyName} must be greater 0");
        }
    }
}
