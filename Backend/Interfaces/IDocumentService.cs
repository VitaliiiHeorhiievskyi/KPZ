using WebApi.Models;
using WebApi.ViewModels;

namespace WebApi.Interfaces;

public interface IDocumentService
{
    Task<IEnumerable<Document>> GetAllByPatientIdAsync(Guid patientId);
    Task<Document> CreateAsync(DocumentViewModel document);
    Task DeleteAsync(Guid id);
}
