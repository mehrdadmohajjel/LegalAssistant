namespace LegalAssistant.Bale.DTOs;

public sealed class BaleMessage
{
    public long MessageId { get; set; }

    public BaleUser From { get; set; } = null!;

    public BaleChat Chat { get; set; } = null!;

    public string? Text { get; set; }
}