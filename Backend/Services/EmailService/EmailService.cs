using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using MimeKit.Text;
using WebApi.Models;
using WebApi.Models.Enums;

namespace WebApi.Services.EmailService
{
    public class EmailService : IEmailService
    {
        private readonly IConfiguration _config;

        public EmailService(IConfiguration config)
        {
            _config = config;
        }

        public void SendEmail(EmailDto request)
        {
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse(_config.GetSection("EmailUsername").Value));
            email.To.Add(MailboxAddress.Parse(request.To));
            email.Subject = request.Subject;
            email.Body = new TextPart(TextFormat.Html) { Text = request.Body };

            using var smtp = new SmtpClient();
            smtp.Connect(_config.GetSection("EmailHost").Value, 587, SecureSocketOptions.StartTls);
            var emailName = _config.GetSection("EmailUsername").Value;
            var emailPass = _config.GetSection("EmailPassword").Value;
            smtp.Authenticate(_config.GetSection("EmailUsername").Value, _config.GetSection("EmailPassword").Value);
            smtp.Send(email);
            smtp.Disconnect(true);
        }

        public void SendEmailToDoctor(Notification notification, Doctor doctor)
        {
            var body = $"<p>Hello {doctor.Name},</p>" +
                       $"<p>You have received a notification for an appointment.</p>" +
                       $"<p>Date and Time: {notification.Date.ToString("yyyy-MM-dd HH:mm")}</p>" +
                       $"<p>Label: {notification.Label}</p>" +
                       $"<p>Description: {notification.Description}</p>" +
                       $"<div style=\"margin-top: 20px;\">" +
                       $"<a href=\"https://localhost:7219/api/Notification/{notification.Id}/2\" style=\"text-decoration: none; margin-right: 10px; padding: 10px 20px; background-color: #4CAF50; color: white; border-radius: 5px;\">Approve</a>" +
                       $"<a href=\"https://localhost:7219/api/Notification/{notification.Id}/1\" style=\"text-decoration: none; padding: 10px 20px; background-color: #f44336; color: white; border-radius: 5px;\">Reject</a>" +
                       $"</div><p>Thank you.</p>";

            SendEmail(new EmailDto()
            {
                To = doctor.Email,
                Subject = "Notification for an appointment.",
                Body = body
            });
        }

        public void SendEmailToPatient(Notification notification, Patient patient)
        {
            var statusColorClass = notification.Status == "REJECTED" ? "rejected" : "approved";

            var body = $@"
                <html lang='en'>
                <head>
                    <meta charset='UTF-8'>
                    <meta name='viewport' content='width=device-width, initial-scale=1.0'>
                    <style>
                        body {{
                            font-family: 'Arial', sans-serif;
                            background-color: #f5f5f5;
                            margin: 0;
                            padding: 20px;
                        }}
                        .container {{
                            max-width: 600px;
                            margin: 0 auto;
                            background-color: #fff;
                            padding: 20px;
                            border-radius: 5px;
                            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
                        }}
                        h1 {{
                            color: #4CAF50;
                            margin-bottom: 20px;
                        }}
                        p {{
                            color: #333;
                            font-size: 16px;
                            line-height: 1.6;
                        }}
                        .status {{
                            font-weight: bold;
                        }}
                        .status.rejected {{
                            color: #f44336;
                        }}
                        .status.approved {{
                            color: #4CAF50;
                        }}
                        .footer {{
                            margin-top: 20px;
                            text-align: center;
                            color: #555;
                        }}
                    </style>
                </head>
                <body>
                    <div class='container'>
                        <h1>Notification Status Updated</h1>
                        <p>Your notification details have been updated:</p>
                        <p><strong>Date and Time:</strong> {notification.Date.ToString("yyyy-MM-dd HH:mm")}</p>
                        <p><strong>Label:</strong> {notification.Label}</p>
                        <p><strong>Description:</strong> {notification.Description}</p>
                        <p><strong>New Status:</strong> <span class='status {statusColorClass}'>{notification.Status}</span></p>
                        <div class='footer'>
                            <p>Thank you for using our service.</p>
                        </div>
                    </div>
                </body>
                </html>
            ";

            SendEmail(new EmailDto()
            {
                To = patient.Email,
                Subject = "Your notification status has been updated.",
                Body = body
            });
        }
    }
}