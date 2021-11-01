using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Options;
using PDSC.Common;

namespace PDSCFramework.Common
{
  public class EmailSender : IEmailSender
  {
    public EmailSender(IOptions<EmailSettings> optionsAccessor)
    {
      Options = optionsAccessor.Value;
    }

    public EmailSettings Options { get; }
    public SmtpClient Client { get; set; }

    public Task SendEmailAsync(string emailTo, string subject, string htmlMessage)
    {
      // Create and build a new MailMessage object
      MailMessage message = new() 
      {
        IsBodyHtml = true,
        From = new MailAddress(Options.FromEmail, Options.FromName),
        Subject = subject,
        Body = htmlMessage
      };
      if (emailTo.Contains(";")) {
        var emails = emailTo.Split(";".ToCharArray());
        for (int i = 0; i < emails.Length; i++) {
          message.To.Add(new MailAddress(emails[i]));
        }
      }
      else {
        message.To.Add(new MailAddress(emailTo));
      }

      if (!string.IsNullOrEmpty(Options.UnsubscribeEmail) && !string.IsNullOrEmpty(Options.UnsubscribeLink)) {
        message.Headers.Add("List-Unsubscribe", $"<mailto: {Options.UnsubscribeEmail}>, <{Options.UnsubscribeLink}>");
      }
      else if (!string.IsNullOrEmpty(Options.UnsubscribeEmail) && string.IsNullOrEmpty(Options.UnsubscribeLink)) {
        message.Headers.Add("List-Unsubscribe", $"<mailto: {Options.UnsubscribeEmail}>");
      }

      Client = new SmtpClient(Options.SMTPServer, Options.SMTPPort)
      {
        // Pass SMTP credentials
        Credentials = new NetworkCredential(Options.SMTPUserName, Options.SMTPKey),

        // Enable SSL encryption
        EnableSsl = true
      };

      return Client.SendMailAsync(message);
    }
  }
}