

namespace AzureFunction
{
    public interface IEmailService
    {
        EmailVerification IsValidEmail(Email email);
        string SendEmail(Email email);
    }
}
