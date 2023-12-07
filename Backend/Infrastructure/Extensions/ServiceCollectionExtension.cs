using WebApi.Services.BlobStorage;

namespace WebApi.Infrastructure.Extensions;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddAzureBlobService(this IServiceCollection services, IConfiguration configuration)
    {
        var options = new AzureBlobServiceOptions();
        var section = configuration.GetSection(AzureBlobServiceOptions.SectionName);
        section.Bind(options);
        services.AddSingleton<IBlobOptions>(options);

        services.AddSingleton<IBlobService, AzureBlobService>();

        return services;
    }
}
