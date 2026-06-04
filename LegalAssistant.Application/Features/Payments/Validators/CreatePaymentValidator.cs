using FluentValidation;
using LegalAssistant.Application.Features.Payments.DTOs;

public sealed class CreatePaymentValidator
    : AbstractValidator<CreatePaymentDto>
{
    public CreatePaymentValidator()
    {
        RuleFor(x => x.ConsultationId)
            .NotEmpty()
            .WithMessage("شناسه مشاوره معتبر نیست.");
    }
}