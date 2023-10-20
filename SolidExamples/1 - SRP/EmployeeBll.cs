namespace SolidExamples.SRP
{
    public class EmployeeBll
    {
        private readonly IEmployeeWageCalculator _employeeWageCalculator;


        public EmployeeBll(IEmployeeWageCalculator employeeWageCalculator)
        {
            _employeeWageCalculator = employeeWageCalculator;
        }

        public double CalculateWage(int id, double hours)
        {
            return _employeeWageCalculator.CalculatePayroll(id, hours);
        }


    }
}
