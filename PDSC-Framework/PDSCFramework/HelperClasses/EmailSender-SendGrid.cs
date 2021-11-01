using System.Security.Cryptography;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Options;
using PDSC.Common;
//using SendGrid;
//using SendGrid.Helpers.Mail;

namespace PDSCFramework.Common
{
  public class EmailSenderSendGrid // : IEmailSender
  {
    public EmailSenderSendGrid(IOptions<EmailSettings> optionsAccessor)
    {
      Options = optionsAccessor.Value;
    }

    public EmailSettings Options { get; }

    //public Task SendEmailAsync(string emailTo, string subject, string htmlMessage)
    //{
    //  return Execute(Options.SMTPKey, subject, htmlMessage, emailTo);
    //}

    //public Task Execute(string apiKey, string subject, string htmlMessage, string emailTo)
    //{
      //var client = new SendGridClient(apiKey);
      //var msg = new SendGridMessage()
      //{
      //  From = new EmailAddress(Options.FromEmail, Options.SMTPUserName),
      //  Subject = subject,
      //  HtmlContent = htmlMessage
      //};
      //if (!string.IsNullOrEmpty(Options.UnsubscribeEmail) && !string.IsNullOrEmpty(Options.UnsubscribeLink)) {
      //  msg.AddHeader("List-Unsubscribe", $"<mailto: {Options.UnsubscribeEmail}>, <{Options.UnsubscribeLink}>");
      //}
      //else if (!string.IsNullOrEmpty(Options.UnsubscribeEmail) && string.IsNullOrEmpty(Options.UnsubscribeLink)) {
      //  msg.AddHeader("List-Unsubscribe", $"<mailto: {Options.UnsubscribeEmail}>");
      //}
      //if (emailTo.Contains(";")) {
      //  var emails = emailTo.Split(";".ToCharArray());
      //  for (int i = 0; i < emails.Length; i++) {
      //    msg.AddTo(new EmailAddress(emails[i]));
      //  }
      //}
      //else {
      //  msg.AddTo(new EmailAddress(emailTo));
      //}

      //// Disable click tracking.
      //// See https://sendgrid.com/docs/User_Guide/Settings/tracking.html
      //msg.SetClickTracking(false, false);

      //return client.SendEmailAsync(msg);
    //}
  }
}