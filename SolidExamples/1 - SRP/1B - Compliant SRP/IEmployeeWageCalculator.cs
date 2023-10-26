using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExamples.SRP
{
    public interface IEmployeeWageCalculator
    {
        double CalculatePayroll(int id, double hours);
    }
}
