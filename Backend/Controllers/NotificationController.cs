using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Interfaces;
using WebApi.Models;
using WebApi.Models.Enums;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        private readonly INotificationService _service;

        public NotificationController(INotificationService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> Create(Notification notification)
        {
            var createdNotification = await _service.CreateAsync(notification);
            return CreatedAtAction(nameof(GetById), new { id = createdNotification.Id }, createdNotification);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _service.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var notification = await _service.GetByIdAsync(id);
            if (notification == null)
            {
                return NotFound();
            }
            return Ok(notification);
        }


        [HttpGet("bypatient/{patientId}")]
        public async Task<IActionResult> GetByPatientId(Guid patientId)
        {
            var notifications = await _service.GetByPatientIdAsync(patientId);
            if (notifications == null)
            {
                return NotFound();
            }
            return Ok(notifications);
        }

        [HttpGet("doctors")]
        public async Task<IActionResult> GetAllDoctors()
        {
            var doctors = await _service.GetAllDoctorsAsync();
            if (doctors == null)
            {
                return NotFound();
            }
            return Ok(doctors);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, Notification notification)
        {
            if (id != notification.Id)
            {
                return BadRequest();
            }

            await _service.UpdateAsync(id, notification);

            return Ok();
        }


        [HttpPut("{id}/{status}")]
        public async Task<IActionResult> ChangeStatus(Guid id, NotificationStatusEnum status)
        {
            await _service.ChangeStatusAsync(id, status);

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _service.DeleteAsync(id);
            return Ok();
        }
    }
}
