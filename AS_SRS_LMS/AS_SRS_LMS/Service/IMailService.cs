using AS_SRS_LMS.Models;

namespace AS_SRS_LMS.Service
{
    public interface IMailService
    {
        Task SendEmailAsync(MailRequest mailRequest);
    }
}
