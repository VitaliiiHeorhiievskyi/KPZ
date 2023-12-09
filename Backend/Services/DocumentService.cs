using WebApi.Models.Enums;
using WebApi.Models;
using WebApi.Interfaces;
using WebApi.Services.BlobStorage;
using WebApi.ViewModels;
using WebApi.DataBase.Repository;

namespace WebApi.Services;

public class DocumentService : IDocumentService
{
    private readonly IDocumentRepository _documentRepository;
    private readonly IBlobService blobService;

    public DocumentService(IDocumentRepository documentRepository, IBlobService blobService)
    {
        _documentRepository = documentRepository;
        this.blobService = blobService;
    }

    public async Task<Document> CreateAsync(DocumentViewModel document)
    {
        var url = await blobService.UploadFileBlobAsync(document.Base64Content, document.FileFormat, CancellationToken.None);
        return await _documentRepository.CreateAsync(document, url);
    }

    public async Task<IEnumerable<Document>> GetAllByPatientIdAsync(Guid patientId)
    {
        return await _documentRepository.GetAllByPatientIdAsync(patientId);
    }

    public async Task DeleteAsync(Guid id)
    {
        await _documentRepository.DeleteAsync(id);
    }

    public async Task ChangeStatusAsync(Guid id, NotificationStatusEnum notificationStatus)
    {
        await _documentRepository.ChangeStatusAsync(id, notificationStatus);
    }
}