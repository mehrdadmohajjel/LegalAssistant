namespace LegalAssistant.Application.Features.Users.DTOs;

public sealed class RegisterUserDto
{
    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Mobile { get; set; } = null!;

    public string? NationalCode { get; set; }

    public string Province { get; set; } = null!;

    public string City { get; set; } = null!;
}