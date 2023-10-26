using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExamples.SRP
{
    public class EmployeeWageCalculator : IEmployeeWageCalculator
    {
        private readonly IEmployeeDal _employeeDal;

        public EmployeeWageCalculator(IEmployeeDal employeeDAL)
        {
            _employeeDal = employeeDAL;
        }

        public double CalculatePayroll(int id, double hours)
        {
            var employee = _employeeDal.GetEmployee(id);

            return employee.Wage * hours;
        }
    }
}
