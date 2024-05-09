using System.Net.Mail;
using System.Net;

namespace Forum
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string message)
        {
            var mail = "aspnet423@gmail.com";
            var pw = "tyndxqgdxhmukruo";

            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                EnableSsl = true,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(mail, pw)
            };

            return client.SendMailAsync(
                new MailMessage(from: "aspnet423@gmail.com",
                                to: email,
                                subject,
                                message
                                ));
        }
    }
}
