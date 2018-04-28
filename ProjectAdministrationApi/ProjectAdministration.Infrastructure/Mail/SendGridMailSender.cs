using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ProjectAdministration.Core.HelperModels;
using ProjectAdministration.Infrastructure.Logger;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace ProjectAdministration.Infrastructure.Mail
{
    public class SendGridMailSender : IEmailSender
    {
        private readonly IProjectAdministrationLogger _projectAdministrationLogger;
        public SendGridMailSender(IProjectAdministrationLogger projectAdministrationLogger1)
        {
            _projectAdministrationLogger = projectAdministrationLogger1;
        }
        private static string GetApiKey()
        {
            return Environment.GetEnvironmentVariable("SENDGRID_APIKEY");
        }
        public async Task<bool> SendSimpleEmail(SendEmailRequest sendEmailRequest)
        {
            var msg = GetBasicSendGridMessage(sendEmailRequest);
            msg.AddContent(MimeType.Text, sendEmailRequest.MailContent);
            return await CallEmailSenderAsync(msg);
        }

        public async Task<bool> SendHtmlEmail(SendEmailRequest sendEmailRequest)
        {
            var msg = GetBasicSendGridMessage(sendEmailRequest);
            msg.SetSubject(sendEmailRequest.MailSubject); msg.AddContent(MimeType.Html, sendEmailRequest.MailContent);
            return await CallEmailSenderAsync(msg);
        }

        private SendGridMessage GetBasicSendGridMessage(SendEmailRequest sendEmailRequest)
        {
            var msg = new SendGridMessage();
            msg.SetFrom(new EmailAddress(sendEmailRequest.MailFromEmail, sendEmailRequest.MailFromName));
            var recipients = new List<EmailAddress>
            {
                new EmailAddress(sendEmailRequest.MailtoEmail, sendEmailRequest.MailTo)
            };
            msg.AddTos(recipients);
            return msg;
        }

        private async Task<bool> CallEmailSenderAsync(SendGridMessage sendGridMessage)
        {
            try
            {
                SendGridClient sendGridClient = new SendGridClient(GetApiKey());
                await sendGridClient.SendEmailAsync(sendGridMessage);
                return true;
            }
            catch (Exception e)
            {
                await _projectAdministrationLogger.LogException(e);
                return false;
            }
        }
    }
}