
using System;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Net.Mail;

namespace AzureFunction
{
    public class EmailService : IEmailService
    {
        public EmailVerification IsValidEmail(Email email)
        {
            if (!new EmailAddressAttribute().IsValid(email.To) || string.IsNullOrWhiteSpace(email.To))
                return new EmailVerification { IsValid = false, ResponseMessage = "Please provide a valid email address." };

            else if (string.IsNullOrWhiteSpace(email.Subject))
                return new EmailVerification { IsValid = false, ResponseMessage = "Please provide an email subject." };

            else if (string.IsNullOrWhiteSpace(email.Body))
                return new EmailVerification { IsValid = false, ResponseMessage = "Please provide a body to the email." };

            else
                return new EmailVerification { IsValid = true, ResponseMessage = "Valid Email" };
        }

        public string SendEmail(Email email)
        {
            SmtpClient client = new("smtp.example.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("username","password"),
                EnableSsl = true,
            };

            try
            {
                // Will fail to send email.
                // client.Send("example@gmail.com", email.To, email.Subject, email.Body);
                client.Dispose();
                return $"Successfully sent email to {email.To}";
            }
            catch (Exception exception)
            {
                client.Dispose();
                return $"Failed to send email to {email.To}\nReason: {exception.Message}";
            }
        }
    }
}
