using PatientHealth.DataBase;
using WebApi.Models.Enums;
using WebApi.Models;
using WebApi.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Services;

public class DocumentService : IDocumentService
{
    private readonly AppDbContext _context;

    public DocumentService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<Document> CreateAsync(Document document)
    {
        document.Id = Guid.NewGuid();
        //TODO: blob storage
        _context.Documents.Add(document);
        await _context.SaveChangesAsync();
        return document;
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
