using Microsoft.EntityFrameworkCore;
using PatientHealth.DataBase;
using WebApi.Helpers;
using WebApi.Interfaces;
using WebApi.Models;
using WebApi.ViewModels;

namespace WebApi.Services;

public class AuthenticationService : IAuthenticationService
{
    private readonly AppDbContext _context;

    public AuthenticationService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<PatientDto?> Login(LoginRequest loginRequest)
    {
        return await _context.Patients
            .Select(p => new PatientDto
            {
                DateOfBirth = p.DateOfBirth,
                FirstName = p.FirstName,
                Address = p.Address,
                AddressId = p.AddressId,
                Email = p.Email,
                Id = p.Id,
                LastName = p.LastName,
                Password = p.Password,
                Sex = p.Sex,
                PhoneNumber = p.PhoneNumber
            }).FirstOrDefaultAsync(p => p.Email == loginRequest.Email && p.Password == loginRequest.Password);
    }
}