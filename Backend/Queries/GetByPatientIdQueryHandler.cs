using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebApi.Interfaces;
using WebApi.Models;

namespace WebApi.Queries
{
    public class GetByPatientIdQueryHandler : IRequestHandler<GetByPatientIdQuery, IActionResult>
    {
        private readonly INotificationService _service;

        public GetByPatientIdQueryHandler(INotificationService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Handle(GetByPatientIdQuery request, CancellationToken cancellationToken)
        {
            var notifications = await _service.GetByPatientIdAsync(request.PatientId);
            if (notifications == null || !notifications.Any())
            {
                return new NotFoundResult();
            }
            return new OkObjectResult(notifications);
        }
    }
}
