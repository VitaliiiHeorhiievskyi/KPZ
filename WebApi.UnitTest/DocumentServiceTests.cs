using Microsoft.EntityFrameworkCore;
using Moq;
using PatientHealth.DataBase;
using WebApi.DataBase.Repository;
using WebApi.Models;
using WebApi.Services.BlobStorage;
using WebApi.ViewModels;
public class DocumentRepositoryTests
{
    [Fact]
    public async Task CreateAsync_ShouldCreateDocument_WhenValidInput()
    {
        // Arrange
        var dbContextOptions = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase(databaseName: "CreateAsync_Database")
            .Options;

        using (var context = new AppDbContext(dbContextOptions))
        {
            var documentRepository = new DocumentRepository(context);
            var patientId = Guid.NewGuid();

            var documentViewModel = new DocumentViewModel
            {
                Name = "Test Document",
                Description = "Description",
                PatientId = patientId
            };

            var blobServiceMock = new Mock<IBlobService>();
            var url = "https://example.com/test.pdf";
            blobServiceMock.Setup(x => x.UploadFileBlobAsync(It.IsAny<string>(), It.IsAny<string>(), default))
                           .ReturnsAsync(url);

            // Act
            var result = await documentRepository.CreateAsync(documentViewModel, url);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(documentViewModel.Name, result.Name);
            Assert.Equal(documentViewModel.Description, result.Description);
            Assert.Equal(patientId, result.PatientId);
            Assert.False(result.IsVerified);
            Assert.Equal(url, result.Url);
            Assert.NotNull(result.Id);

            // Additional checks for Patient relationship
            Assert.Null(result.Patient); // Patient should be null since it's not loaded
        }
    }

    [Fact]
    public async Task GetAllByPatientIdAsync_ShouldReturnDocuments_WhenValidPatientId()
    {
        // Arrange
        var dbContextOptions = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase(databaseName: "GetAllByPatientIdAsync_Database")
            .Options;

        using (var context = new AppDbContext(dbContextOptions))
        {
            var documentRepository = new DocumentRepository(context);
            var patientId = Guid.NewGuid();
            var documents = new List<Document>
            {
                new Document
                {
                    PatientId = patientId,
                    Id = Guid.NewGuid(),
                    Name = "Test Document 1",
                    Description = "Description 1",
                    UploadDate = DateTime.UtcNow,
                    Url = "https://example.com/document1.pdf",
                    IsVerified = false
                },
                new Document
                {
                    PatientId = patientId,
                    Id = Guid.NewGuid(),
                    Name = "Test Document 2",
                    Description = "Description 2",
                    UploadDate = DateTime.UtcNow,
                    Url = "https://example.com/document2.pdf",
                    IsVerified = true
                }
            };

            context.Documents.AddRange(documents);
            context.SaveChanges();

            // Act
            var result = await documentRepository.GetAllByPatientIdAsync(patientId);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(2, result.Count());

            // Additional checks for Patient relationship
            foreach (var document in result)
            {
                Assert.Null(document.Patient); // Patient should be null since it's not loaded
            }
        }
    }

    [Fact]
    public async Task DeleteAsync_ShouldDeleteDocument_WhenValidId()
    {
        // Arrange
        var dbContextOptions = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase(databaseName: "DeleteAsync_Database")
            .Options;

        using (var context = new AppDbContext(dbContextOptions))
        {
            var documentRepository = new DocumentRepository(context);
            var document = new Document
            {
                PatientId = Guid.NewGuid(),
                Id = Guid.NewGuid(),
                Name = "Test Document 1",
                Description = "Description 1",
                UploadDate = DateTime.UtcNow,
                Url = "https://example.com/document1.pdf",
                IsVerified = false
            };
            context.Documents.Add(document);
            context.SaveChanges();

            // Act
            await documentRepository.DeleteAsync(document.Id);

            // Assert
            var deletedDocument = await context.Documents.FindAsync(document.Id);
            Assert.Null(deletedDocument);
        }
    }
}