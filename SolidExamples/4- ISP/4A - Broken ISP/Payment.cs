using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExamples.BrokenISP
{
    public class Payment : IPayment
    {
        public object GetStatus()
        {
            throw new NotImplementedException();
        }

        public void PayWithBankTransfer()
        {
            throw new NotImplementedException();
        }

        public void SettleLoanAgreement()
        {
            throw new NotImplementedException();
        }
    }
}
