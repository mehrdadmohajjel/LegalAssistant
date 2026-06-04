namespace LegalAssistant.Shared.Exceptions;

public sealed class ValidationException
    : Exception
{
    public Dictionary<string, string[]> Errors { get; }

    public ValidationException(
        Dictionary<string, string[]> errors)
    {
        Errors = errors;
    }
}