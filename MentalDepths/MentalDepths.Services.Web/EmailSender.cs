namespace MentalDepths.Services.Web
{
    using Microsoft.AspNetCore.Identity.UI.Services;
    using Microsoft.IdentityModel.Tokens;
    using System.Net;
    using System.Net.Mail;

    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string message)
        {
            var mail = "georgigeorgievbrezho@gmail.com";
            var pw = "tzvtkanlokvjayjt";

            var client = new SmtpClient("smtp.gmail.com", 587);
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential(mail, pw);
            client.EnableSsl = true;

            return client
                .SendMailAsync(new MailMessage(
                    from: mail,
                    to: email,
                    subject,
                    message
                    ));

        }
    }
}
