using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExamples.CompliantISP
{
    public class BasePayment : IPayment
    {
        public object GetStatus()
        {
            throw new NotImplementedException();
        }
    }
}
