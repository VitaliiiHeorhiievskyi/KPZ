using Microsoft.EntityFrameworkCore;
using PatientHealth.DataBase;
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

    public async Task<Patient?> Login(LoginRequest loginRequest)
    {
        return await _context.Patients.FirstOrDefaultAsync(p => p.Email == loginRequest.Email && p.Password == loginRequest.Password);
    }
}