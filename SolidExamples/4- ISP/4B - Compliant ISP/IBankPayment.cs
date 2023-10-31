using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExamples.CompliantISP
{
    internal interface IBankPayment : IPayment
    {

        void PayWithBankTransfer();

    }
}
