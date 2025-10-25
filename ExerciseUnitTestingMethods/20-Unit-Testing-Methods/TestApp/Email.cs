using System.Net.Mail;

namespace TestApp;

public class Email
{
    public static bool IsValidEmail(string email)
    {
        if (string.IsNullOrWhiteSpace(email))
        {
            return false;
        }

        return MailAddress.TryCreate(email, out _);//връща дали е вярно или грешно

        // null не може да се запише като int. string number = null;(prazno)
    }
}
