using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebApi.Interfaces;
using WebApi.Models;
using WebApi.Models.Enums;
using WebApi.Queries;
using WebApi.Services.EmailService;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        private readonly INotificationService _service;
        private readonly IEmailService _emailService;
        private readonly IPatientService _patientService;
        private readonly IMediator _mediator;

        public NotificationController(INotificationService service, IEmailService emailService, IPatientService patientService, IMediator mediator)
        {
            _service = service;
            _emailService = emailService;
            _patientService = patientService;
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Create(Notification notification)
        {
            var createdNotification = await _service.CreateAsync(notification);

            var doctors = await _service.GetAllDoctorsAsync();

            var doctor = doctors.FirstOrDefault(d => d.Id == notification.DoctorId);
            doctor = new Doctor() { Email = "georgiievsky@gmail.com", Name = "Mr. Proper" };

            _emailService.SendEmailToDoctor(notification, doctor);

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
            return await _mediator.Send(new GetByPatientIdQuery(patientId));
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

        [HttpGet("{id}/{status}")]
        public async Task<IActionResult> ChangeStatus(Guid id, string status)
        {
            await _service.ChangeStatusAsync(id, status);

            var notification = await _service.GetByIdAsync(id);
            var patient = await _patientService.GetByIdAsync(notification.PatientId);
            patient = new Patient() { Email = "georgiievsky@gmail.com" };

            _emailService.SendEmailToPatient(notification, patient);

            string htmlContent = $@"
                <!DOCTYPE html>
                <html lang=""en"">
                <head>
                    <meta charset=""UTF-8"">
                    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
                    <title>Task Completed</title>
                    <style>
                        body {{
                            background-color: #f5f5f5;
                            font-family: 'Arial', sans-serif;
                            display: flex;
                            align-items: center;
                            justify-content: center;
                            height: 100vh;
                            margin: 0;
                        }}
                        .container {{
                            text-align: center;
                        }}
                        h1 {{
                            color: #4CAF50;
                            margin-bottom: 20px;
                        }}
                        p {{
                            color: #555;
                            font-size: 18px;
                            line-height: 1.6;
                        }}
                        .button {{
                            display: inline-block;
                            padding: 10px 20px;
                            background-color: #4CAF50;
                            color: #fff;
                            text-decoration: none;
                            font-size: 16px;
                            border-radius: 5px;
                            cursor: pointer;
                            transition: background-color 0.3s;
                        }}
                        .button:hover {{
                            background-color: #45a049;
                        }}
                    </style>
                </head>
                <body>
                    <div class=""container"">
                        <h1>Task Completed!</h1>
                        <p>Your action was successful.</p>
                        <button class=""button"" onclick=""closePage()"">OK</button>
                    </div>

                    <script>
                        function closePage() {{
                            window.close(); // Close the current browser window/tab
                        }}
                    </script>
                </body>
                </html>
            ";

            return Content(htmlContent, "text/html");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _service.DeleteAsync(id);
            return Ok();
        }
    }
}