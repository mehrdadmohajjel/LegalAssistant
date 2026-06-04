using System.Text.Json.Serialization;

namespace LegalAssistant.Infrastructure.Integrations.Bale.Requests;

public sealed class SendMessageRequest
{
    [JsonPropertyName("chat_id")]
    public long ChatId { get; set; }

    [JsonPropertyName("text")]
    public string Text { get; set; } = string.Empty;
}