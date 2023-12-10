namespace WebApi.ViewModels;

public class DocumentViewModel
{
    public string Name { get; set; }
    public string Description { get; set; }
    public Guid PatientId { get; set; }
    public string Base64Content { get; set; }
}
