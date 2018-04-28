namespace ProjectAdministration.Core.HelperModels
{
    public class SendEmailRequest
    {
        public string MailtoEmail { get; set; }
        public string MailTo { get; set; }
        public string MailFromEmail { get; set; }
        public string MailFromName { get; set; }
        public string MailSubject { get; set; }
        public string MailContent { get; set; }
    }
}