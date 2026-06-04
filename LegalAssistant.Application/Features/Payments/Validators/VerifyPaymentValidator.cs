using FluentValidation;
using LegalAssistant.Application.Features.Payments.DTOs;

public sealed class VerifyPaymentValidator
    : AbstractValidator<VerifyPaymentDto>
{
    public VerifyPaymentValidator()
    {
        RuleFor(x => x.Authority)
            .NotEmpty()
            .WithMessage("Authority الزامی است.");

        RuleFor(x => x.Status)
            .NotEmpty()
            .WithMessage("Status الزامی است.");
    }
}