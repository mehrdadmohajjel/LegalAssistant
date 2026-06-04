namespace LegalAssistant.Application.Interfaces.External;

public interface IBaleApiClient
{
    Task SendTextAsync(
        long chatId,
        string text,
        CancellationToken cancellationToken = default);
}