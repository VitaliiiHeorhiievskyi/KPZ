using Microsoft.EntityFrameworkCore;
using PatientHealth.DataBase;
using WebApi.Models;
using WebApi.Models.Enums;
using WebApi.Services.BlobStorage;
using WebApi.ViewModels;

namespace WebApi.DataBase.Repository
{
    public class DocumentRepository : IDocumentRepository
    {
        private readonly AppDbContext _context;

        public DocumentRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Document> CreateAsync(DocumentViewModel document, string url)
        {
            var newDocument = new Document
            {
                Id = Guid.NewGuid(),
                Name = document.Name,
                Description = document.Description,
                PatientId = document.PatientId,
                UploadDate = DateTime.UtcNow,
                IsVerified = false,
                Url = url
            };

            _context.Documents.Add(newDocument);
            await _context.SaveChangesAsync();

            return newDocument;
        }

        public async Task<IEnumerable<Document>> GetAllByPatientIdAsync(Guid patientId)
        {
            return await _context.Documents
                .Where(p => p.PatientId == patientId)
                .ToListAsync();
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
    }
}
