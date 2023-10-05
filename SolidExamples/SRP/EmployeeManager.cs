namespace SolidExamples.SRP
{
    public class EmployeeManager
    {

        /*
         * SRP: Single Responsibility Principle
         *  "A class should have only one reason to change"
         *  Accentrando più di una responsabilità in un'unica classe, si crea rigidità e "accoppiamento" (coupling) di un comportamento con un altro, e il cambio di
         *  requisiti di uno dei comportamenti potrebbe sfociare in una modifica alla stessa classe e possibilmente anche a porzioni di codice che non interessano
         *  necessariamente all'ambito della modifica. 
         *  In breve: più i requisiti richiano di cambiare su una delle responsabilità della classe, più si rende necessario disaccoppiarle
         */

        public double CalculatePayroll(int id, double hours)
        {
            var employee = GetEmployee(id);

            return employee.Wage * hours;
        }

        public void PersistToDb(Employee employee)
        {
            //WRITE ON DB
        }

        public Employee GetEmployee(int id)
        {
            return new Employee(id, "Tizio", 30);
        }


    }
}
