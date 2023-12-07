using Azure.Storage.Blobs;

namespace WebApi.Services.BlobStorage;

public class AzureBlobService : IBlobService
{
    private readonly BlobServiceClient blobServiceClient;
    private readonly IBlobOptions options;

    public AzureBlobService(IBlobOptions options)
    {
        this.options = options;
        blobServiceClient = new BlobServiceClient(this.options.ConnectionString);
    }

    public async Task<string> UploadFileBlobAsync(string base64, string fileFormat, CancellationToken cancellationToken)
    {
        var fileName = Guid.NewGuid() + fileFormat;
        var containerClient = blobServiceClient.GetBlobContainerClient(options.ContainerName);

        var blobClient = containerClient.GetBlobClient(fileName);

        var bytes = Convert.FromBase64String(base64);

        using (var stream = new MemoryStream(bytes))
        {
            await blobClient.UploadAsync(stream, cancellationToken);
        }

        return blobClient.Uri.ToString();
    }
}