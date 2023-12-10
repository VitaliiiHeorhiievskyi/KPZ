using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Moq;
using PatientHealth.DataBase;
using WebApi.Interfaces;
using WebApi.Models;
using WebApi.Services;
using WebApi.ViewModels;
using Xunit;

namespace WebApi.Services.Tests
{
    public class AuthenticationServiceTests
    {
        [Fact]
        public async Task Login_ValidCredentials_ReturnsPatient()
        {
            // Arrange
            var loginRequest = new LoginRequest { Email = "john.doe@example.com", Password = "password123" };

            var dbContextOptions = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: "InMemory_Test_Database")
                .Options;

            using var dbContext = new AppDbContext(dbContextOptions);
            var authenticationService = new AuthenticationService(dbContext);

            var existingPatient = new Patient
            {
                Id = new Guid(),
                Email = "john.doe@example.com",
                Password = "password123",
                Address = "asd",
                FirstName = "asd",
                LastName = "asd",
                PhoneNumber = "1234567890",
            };

            dbContext.Patients.Add(existingPatient);
            dbContext.SaveChanges();

            // Act
            var result = await authenticationService.Login(loginRequest);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(existingPatient, result);
        }

        [Fact]
        public async Task Login_InvalidCredentials_ReturnsNull()
        {
            // Arrange
            var loginRequest = new LoginRequest { Email = "john.doe@example.com", Password = "wrongPassword" };

            var dbContextOptions = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: "InMemory_Test_Database")
                .Options;

            using var dbContext = new AppDbContext(dbContextOptions);
            var authenticationService = new AuthenticationService(dbContext);

            // Act
            var result = await authenticationService.Login(loginRequest);

            // Assert
            Assert.Null(result);
        }
    }
}
