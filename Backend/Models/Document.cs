namespace WebApi.Models;

public class Document
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime UploadDate { get; set; }
    public string Url { get; set; }
    public bool IsVerified { get; set; }

    public Guid PatientId { get; set; }

    public Patient? Patient { get; set; }
}
