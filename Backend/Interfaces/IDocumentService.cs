using WebApi.Models;

namespace WebApi.Interfaces;

public interface IDocumentService
{
    Task<IEnumerable<Document>> GetAllByPatientIdAsync(Guid patientId);
    Task<Document> CreateAsync(Document document);
    Task DeleteAsync(Guid id);
}
