﻿using PatientHealth.DataBase;
using WebApi.Models.Enums;
using WebApi.Models;
using WebApi.Interfaces;
using Microsoft.EntityFrameworkCore;
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