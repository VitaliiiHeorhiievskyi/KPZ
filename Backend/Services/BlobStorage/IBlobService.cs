namespace WebApi.Services.BlobStorage;

public interface IBlobService
{
    Task<string> UploadFileBlobAsync(string base64, string fileFormat, CancellationToken cancellationToken);
}
