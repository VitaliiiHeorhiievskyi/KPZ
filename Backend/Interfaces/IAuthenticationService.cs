using WebApi.Models;
using WebApi.ViewModels;

namespace WebApi.Interfaces;

public interface IAuthenticationService
{
    Task<PatientDto?> Login(LoginRequest loginRequest);
}