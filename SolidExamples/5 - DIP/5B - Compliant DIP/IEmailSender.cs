namespace SolidExamples.CompliantDIP
{
    internal interface IEmailSender
    {
        void Send(string from, string to, string message);
    }
}
