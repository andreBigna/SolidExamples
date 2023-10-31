using SolidExamples.CompliantISP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExamples.CompliantISP
{
    public class BankPayment : BasePayment, IBankPayment
    {
        public void PayWithBankTransfer()
        {
            throw new NotImplementedException();
        }
    }
}
