using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExamples.CompliantDIP
{
    internal class MySmtpClient : IEmailSender
    {
        public void Send(string from, string to, string message)
        {
            System.Diagnostics.Debug.WriteLine($"I'm sending an email");
        }
    }
}
