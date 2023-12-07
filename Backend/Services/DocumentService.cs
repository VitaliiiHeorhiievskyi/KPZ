using PatientHealth.DataBase;
using WebApi.Models.Enums;
using WebApi.Models;
using WebApi.Interfaces;
using Microsoft.EntityFrameworkCore;
using WebApi.Services.BlobStorage;
using WebApi.ViewModels;

namespace WebApi.Services;

public class DocumentService : IDocumentService
{
    private readonly AppDbContext _context;
    private readonly IBlobService blobService;

    public DocumentService(AppDbContext context, IBlobService blobService)
    {
        _context = context;
        this.blobService = blobService;
    }

    public async Task<Document> CreateAsync(DocumentViewModel document)
    {
        var newDocument = new Document();
        newDocument.Id = Guid.NewGuid();
        newDocument.Name = document.Name;
        newDocument.Description = document.Description;
        newDocument.PatientId = document.PatientId;
        newDocument.UploadDate = DateTime.UtcNow;
        newDocument.IsVerified = false;
        newDocument.Url = await blobService.UploadFileBlobAsync(document.Base64Content, document.FileFormat, CancellationToken.None);
        _context.Documents.Add(newDocument);
        await _context.SaveChangesAsync();
        return newDocument;
    }

    public async Task<IEnumerable<Document>> GetAllByPatientIdAsync(Guid patientId)
    {
        return await _context.Documents.Where(p => p.PatientId == patientId).ToListAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var document = await _context.Documents.FindAsync(id);
        if (document != null)
        {
            _context.Documents.Remove(document);
            await _context.SaveChangesAsync();
        }
    }

    public async Task ChangeStatusAsync(Guid id, NotificationStatusEnum notificationStatus)
    {
        var existingNotification = await _context.Notifications.FindAsync(id);
        if (existingNotification != null)
        {
            existingNotification.Status = notificationStatus;

            await _context.SaveChangesAsync();
        }
    }
}
