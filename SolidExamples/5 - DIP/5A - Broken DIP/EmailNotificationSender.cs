using System.Net.Mail;

namespace SolidExamples.BrokenDIP
{
    internal class EmailNotificationSender
    {
        private readonly SmtpClient _smtpClient;

        public EmailNotificationSender(SmtpClient smtpClient)
        {
            _smtpClient = smtpClient;
        }

        public void Send(string from, string to, string message)
        {
            _smtpClient.Send(from, to, "Hello World", message);
        }
    }
}
