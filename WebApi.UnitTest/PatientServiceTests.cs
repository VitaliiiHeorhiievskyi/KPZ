using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Moq;
using PatientHealth.DataBase;
using WebApi.Interfaces;
using WebApi.Migrations;
using WebApi.Models;
using Xunit;

namespace WebApi.Services.Tests
{
    public class PatientServiceTests
    {
        private DbContextOptions<AppDbContext> CreateInMemoryDbContextOptions(string databaseName)
        {
            return new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: databaseName)
                .Options;
        }

        [Fact]
        public async Task GetByIdAsync_ReturnsPatient()
        {
            // Arrange
            var id = Guid.NewGuid();
            var dbContextOptions = CreateInMemoryDbContextOptions("InMemory_Test_Database");
            using var dbContext = new AppDbContext(dbContextOptions);
            var patientService = new PatientService(dbContext);

            var patient = new Patient
            {
                Id = id,
                FirstName = "John",
                LastName = "Doe",
                Address = new PatientAddress
                {
                    Address = "asd",
                    City = "asd",
                    Country = "asd"
                },
                Email = "asd",
                Password = "ads",
                Sex = "MALE",
                DateOfBirth = DateTime.Now,
                PhoneNumber = "asd"
            };
            dbContext.Patients.Add(patient);
            dbContext.SaveChanges();

            // Act
            var result = await patientService.GetByIdAsync(id);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(id, result?.Id);
            Assert.Equal("John", result?.FirstName);
            Assert.Equal("Doe", result?.LastName);
        }

        [Fact]
        public async Task GetByIdAsync_ReturnsNullForNonExistentPatient()
        {
            // Arrange
            var id = Guid.NewGuid();
            var dbContextOptions = CreateInMemoryDbContextOptions("InMemory_Test_Database");
            using var dbContext = new AppDbContext(dbContextOptions);
            var patientService = new PatientService(dbContext);

            // Act
            var result = await patientService.GetByIdAsync(id);

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public async Task UpdateAsync_UpdatesPatient()
        {
            // Arrange
            var dbContextOptions = CreateInMemoryDbContextOptions("InMemory_Test_Database");
            using var dbContext = new AppDbContext(dbContextOptions);
            var patientService = new PatientService(dbContext);

            var existingPatient = new Patient
            {
                Id = Guid.NewGuid(),
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@example.com",
                Password = "oldPassword",
                DateOfBirth = new DateTime(1990, 1, 1),
                Address = new PatientAddress
                {
                    Address = "123 Main St",
                    City = "asd",
                    Country = "asd"
                },
                PhoneNumber = "555-1234",
                Sex = "MALE"
            };

            dbContext.Patients.Add(existingPatient);
            dbContext.SaveChanges();

            var updatedPatient = new Patient
            {
                Id = existingPatient.Id,
                FirstName = "Jane",
                LastName = "Doe",
                Email = "jane.doe@example.com",
                Password = "newPassword",
                DateOfBirth = new DateTime(1995, 2, 2),
                Address = new PatientAddress
                {
                    Address = "123 Main St",
                    City = "asd",
                    Country = "asd"
                },
                PhoneNumber = "555-5678",
                Sex = "FEMALE"
            };

            // Act
            await patientService.UpdateAsync(updatedPatient);

            // Assert
            var updatedPatientFromDb = dbContext.Patients.FirstOrDefault(p => p.Id == updatedPatient.Id);
            Assert.NotNull(updatedPatientFromDb);
            Assert.Equal("Jane", updatedPatientFromDb.FirstName);
            Assert.Equal("Doe", updatedPatientFromDb.LastName);
            Assert.Equal("jane.doe@example.com", updatedPatientFromDb.Email);
            Assert.Equal("newPassword", updatedPatientFromDb.Password);
            Assert.Equal(new DateTime(1995, 2, 2), updatedPatientFromDb.DateOfBirth);
            Assert.Equal("555-5678", updatedPatientFromDb.PhoneNumber);
            Assert.Equal("FEMALE", updatedPatientFromDb.Sex);
        }

        [Fact]
        public async Task UpdateAsync_DoesNotUpdateForNonExistentPatient()
        {
            // Arrange
            var dbContextOptions = CreateInMemoryDbContextOptions("InMemory_Test_Database");
            using var dbContext = new AppDbContext(dbContextOptions);
            var patientService = new PatientService(dbContext);

            var nonExistentPatient = new Patient
            {
                Id = Guid.NewGuid(),
                FirstName = "Non",
                LastName = "Existent"
            };

            // Act
            await patientService.UpdateAsync(nonExistentPatient);

            // Assert
            var nonExistentPatientFromDb = dbContext.Patients.FirstOrDefault(p => p.Id == nonExistentPatient.Id);
            Assert.Null(nonExistentPatientFromDb);
        }
    }
}
