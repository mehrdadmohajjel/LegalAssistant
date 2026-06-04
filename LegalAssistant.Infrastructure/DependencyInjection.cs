using LegalAssistant.Application.Interfaces.External;
using LegalAssistant.Infrastructure.Integrations.Bale;
using LegalAssistant.Infrastructure.Options;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace LegalAssistant.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services.Configure<BaleOptions>(
            configuration.GetSection(
                BaleOptions.SectionName));

        services.AddHttpClient<
            IBaleApiClient,
            BaleApiClient>();

        return services;
    }
}