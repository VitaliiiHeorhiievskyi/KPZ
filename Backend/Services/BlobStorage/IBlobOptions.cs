namespace WebApi.Services.BlobStorage;

public interface IBlobOptions
{
    string ConnectionString { get; set; }
    string ContainerName { get; set; }
    int SasTokenExpirationTime { get; set; }
}
