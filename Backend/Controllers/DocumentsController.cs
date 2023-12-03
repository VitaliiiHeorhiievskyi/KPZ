using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Interfaces;
using WebApi.Models;
using WebApi.Models.Enums;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentsController : ControllerBase
    {
        private readonly IDocumentService _service;

        public DocumentsController(IDocumentService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> Create(Document document)
        {
            var createdDocument = await _service.CreateAsync(document);

            if (createdDocument is null)
            {
                return BadRequest();
            }

            return Ok();
        }

        [HttpGet("{patientId}")]
        public async Task<IActionResult> GetAllByPatientId(Guid patientId)
        {
            return Ok(await _service.GetAllByPatientIdAsync(patientId));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _service.DeleteAsync(id);
            return Ok();
        }
    }
}
