using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExamples.SRP
{
    public class EmployeeWageCalculator : IEmployeeWageCalculator
    {
        private readonly IEmployeeDAL _employeeDAL;

        public EmployeeWageCalculator(IEmployeeDAL employeeDAL)
        {
            _employeeDAL = employeeDAL;
        }

        public double CalculatePayroll(int id, double hours)
        {
            var employee = _employeeDAL.GetEmployee(id);

            return employee.Wage * hours;
        }
    }
}
