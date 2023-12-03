using WebApi.Models;

namespace WebApi.Services.EmailService
{
    public interface IEmailService
    {
        void SendEmail(EmailDto request);

        void SendEmailToDoctor(Notification notification, Doctor doctor);

        void SendEmailToPatient(Notification notification, Patient patient);
    }
}