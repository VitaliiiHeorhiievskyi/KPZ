using Microsoft.EntityFrameworkCore;
using PatientHealth.DataBase;
using WebApi.Interfaces;
using WebApi.Models;

namespace WebApi.Services;

public class PatientService : IPatientService
{
    private readonly AppDbContext _context;

    public PatientService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<Patient?> GetByIdAsync(Guid id)
    {
        return await _context.Patients.Include(p => p.Address).FirstOrDefaultAsync(p => p.Id == id);
    }

    public async Task UpdateAsync(Patient updatedPatient)
    {
        var patient = await _context.Patients.FindAsync(updatedPatient.Id);
        if (patient != null)
        {
            patient.FirstName = updatedPatient.FirstName;
            patient.LastName = updatedPatient.LastName;
            patient.Email = updatedPatient.Email;
            patient.Password = updatedPatient.Password;
            patient.DateOfBirth = updatedPatient.DateOfBirth;
            patient.Address = updatedPatient.Address;
            patient.PhoneNumber = updatedPatient.PhoneNumber;
            patient.Sex = updatedPatient.Sex;

            await _context.SaveChangesAsync();
        }
    }
}