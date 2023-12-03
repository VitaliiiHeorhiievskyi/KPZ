using WebApi.Models;

namespace WebApi.Interfaces;

public interface IPatientService
{
    Task<Patient?> GetByIdAsync(Guid id);

    Task UpdateAsync(Patient patient);
}