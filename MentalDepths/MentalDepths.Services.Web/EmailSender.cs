namespace MentalDepths.Services.Web
{
    using MentalDepths.Web.ViewModels.Web;
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
        public async Task<EmailVM> GeneratePossitiveOutcome(string email) 
        {
            var vm = new EmailVM();
            vm.Email = email;
            vm.Subject = "Great news!";
            vm.Message = $"You have been accepted for the job you applied for! Contact us on this number - {MentalDepths.Common.Constatnts.Office.PhoneNumber} whenever possible so we can finalise some minor arrangements";
            return vm;
        }
        public async Task<EmailVM> GenerateNegativeOutcome(string email)
        {
            var vm = new EmailVM();
            vm.Email = email;
            vm.Subject = "Unfortunate coincidence!";
            vm.Message = $"It pains us greatly to inform you that the position you applied for has been occupied by someone else. We would love to hear from you in the future but for now we can only wish you best of luck!";
            return vm;
        }
    }
}
