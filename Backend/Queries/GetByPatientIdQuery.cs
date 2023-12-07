using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Queries
{
    public class GetByPatientIdQuery : IRequest<IActionResult>
    {
        public Guid PatientId { get; }

        public GetByPatientIdQuery(Guid patientId)
        {
            PatientId = patientId;
        }
    }
}
