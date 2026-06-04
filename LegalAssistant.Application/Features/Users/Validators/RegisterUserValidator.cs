using FluentValidation;
using LegalAssistant.Application.Features.Users.DTOs;

namespace LegalAssistant.Application.Features.Users.Validators;

public sealed class RegisterUserValidator
    : AbstractValidator<RegisterUserDto>
{
    public RegisterUserValidator()
    {
        RuleFor(x => x.FirstName)
            .NotEmpty()
            .WithMessage("نام الزامی است.")
            .MaximumLength(100)
            .WithMessage("نام نمی‌تواند بیشتر از 100 کاراکتر باشد.");

        RuleFor(x => x.LastName)
            .NotEmpty()
            .WithMessage("نام خانوادگی الزامی است.")
            .MaximumLength(100)
            .WithMessage("نام خانوادگی نمی‌تواند بیشتر از 100 کاراکتر باشد.");

        RuleFor(x => x.Mobile)
            .NotEmpty()
            .WithMessage("شماره موبایل الزامی است.")
            .Matches(@"^09\d{9}$")
            .WithMessage("فرمت شماره موبایل صحیح نیست.");

        RuleFor(x => x.Province)
            .NotEmpty()
            .WithMessage("استان الزامی است.");

        RuleFor(x => x.City)
            .NotEmpty()
            .WithMessage("شهر الزامی است.");

        RuleFor(x => x.NationalCode)
            .Must(BeValidNationalCode)
            .When(x => !string.IsNullOrWhiteSpace(x.NationalCode))
            .WithMessage("کد ملی معتبر نیست.");
    }

    private bool BeValidNationalCode(string? nationalCode)
    {
        if (string.IsNullOrWhiteSpace(nationalCode))
            return true;

        if (nationalCode.Length != 10)
            return false;

        if (!nationalCode.All(char.IsDigit))
            return false;

        var check =
            int.Parse(nationalCode[9].ToString());

        var sum =
            Enumerable.Range(0, 9)
                .Sum(x =>
                    int.Parse(nationalCode[x].ToString())
                    * (10 - x));

        var remainder = sum % 11;

        return remainder < 2
            ? check == remainder
            : check == 11 - remainder;
    }
}