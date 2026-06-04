using FluentValidation;
using LegalAssistant.Application.Features.Consultations.DTOs;

public sealed class CreateConsultationValidator
    : AbstractValidator<CreateConsultationDto>
{
    public CreateConsultationValidator()
    {
        RuleFor(x => x.Question)
            .NotEmpty()
            .WithMessage("متن سوال الزامی است.")

            .MinimumLength(20)
            .WithMessage("سوال باید حداقل 20 کاراکتر باشد.")

            .MaximumLength(10000)
            .WithMessage("سوال بیش از حد طولانی است.");
    }
}