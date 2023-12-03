using Microsoft.AspNetCore.Mvc;
using WebApi.Interfaces;
using WebApi.Models;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PatientsController : ControllerBase
{
    private readonly IPatientService _service;

    public PatientsController(IPatientService service)
    {
        _service = service;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var patient = await _service.GetByIdAsync(id);
        if (patient == null)
        {
            return NotFound();
        }
        return Ok(patient);
    }

    [HttpPut]
    public async Task<IActionResult> Update(Patient patient)
    {
        await _service.UpdateAsync(patient);

        return Ok();
    }
}