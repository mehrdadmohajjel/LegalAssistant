using System.Net.Http.Json;
using LegalAssistant.Application.Interfaces.External;
using LegalAssistant.Infrastructure.Integrations.Bale.Requests;
using LegalAssistant.Infrastructure.Options;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace LegalAssistant.Infrastructure.Integrations.Bale;

public sealed class BaleApiClient
    : IBaleApiClient
{
    private readonly HttpClient _httpClient;

    private readonly BaleOptions _options;

    private readonly ILogger<BaleApiClient> _logger;

    public BaleApiClient(
        HttpClient httpClient,
        IOptions<BaleOptions> options,
        ILogger<BaleApiClient> logger)
    {
        _httpClient = httpClient;
        _options = options.Value;
        _logger = logger;
    }

    public async Task SendTextAsync(
        long chatId,
        string text,
        CancellationToken cancellationToken = default)
    {
        var request =
            new SendMessageRequest
            {
                ChatId = chatId,
                Text = text
            };

        var url =
            $"{_options.BaseUrl}/bot{_options.Token}/sendMessage";

        var response =
            await _httpClient.PostAsJsonAsync(
                url,
                request,
                cancellationToken);

        if (!response.IsSuccessStatusCode)
        {
            var error =
                await response.Content
                    .ReadAsStringAsync(cancellationToken);

            _logger.LogError(
                "Bale Send Message Failed: {Error}",
                error);

            throw new Exception(
                $"Bale Error : {error}");
        }
    }
}