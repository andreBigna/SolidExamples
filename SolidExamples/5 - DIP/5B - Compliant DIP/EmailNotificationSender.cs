using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExamples.CompliantDIP
{
    internal class EmailNotificationSender
    {
        private readonly IEmailSender _emailSender;

        public EmailNotificationSender(IEmailSender emailSender)
        {
            _emailSender = emailSender;
        }

        public void Send(string from, string to, string message)
        {
            _emailSender.Send(from, to, message);
        }

    }
}
