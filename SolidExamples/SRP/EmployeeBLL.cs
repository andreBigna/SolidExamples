namespace SolidExamples.SRP
{
    public class EmployeeBLL
    {
        private readonly IEmployeeWageCalculator _employeeWageCalculator;

        /*
         * SRP: Single Responsibility Principle
         *  "A class should have only one reason to change"
         *  Accentrando più di una responsabilità in un'unica classe, si crea rigidità e "accoppiamento" (coupling) di un comportamento con un altro, e il cambio di
         *  requisiti di uno dei comportamenti potrebbe sfociare in una modifica alla stessa classe e possibilmente anche a porzioni di codice che non interessano
         *  necessariamente all'ambito della modifica. 
         *  In breve: più i requisiti richiano di cambiare su una delle responsabilità della classe, più si rende necessario disaccoppiarle
         */

        public EmployeeBLL(IEmployeeWageCalculator employeeWageCalculator)
        {
            _employeeWageCalculator = employeeWageCalculator;
        }

        public double CalculateWage(int id, double hours)
        {
            return _employeeWageCalculator.CalculatePayroll(id, hours);
        }


    }
}
