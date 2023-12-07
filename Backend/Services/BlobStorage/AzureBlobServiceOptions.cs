namespace WebApi.Services.BlobStorage;

public class AzureBlobServiceOptions : IBlobOptions
{
    public const string SectionName = "FileStorage:Azure";
    public string ConnectionString { get; set; }
    public string ContainerName { get; set; }
    public int SasTokenExpirationTime { get; set; }
}
