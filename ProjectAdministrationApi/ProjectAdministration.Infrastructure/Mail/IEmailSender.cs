using System.Threading.Tasks;
using ProjectAdministration.Core.HelperModels;

namespace ProjectAdministration.Infrastructure.Mail
{
    public interface IEmailSender
    {
        Task<bool> SendSimpleEmail(SendEmailRequest sendEmailRequest);

        Task<bool> SendHtmlEmail(SendEmailRequest sendEmailRequest);
    }
}