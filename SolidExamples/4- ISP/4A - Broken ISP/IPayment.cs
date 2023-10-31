﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExamples.BrokenISP
{
    public interface IPayment
    {
        object GetStatus();

        void PayWithBankTransfer();

        void SettleLoanAgreement();
    }
}
