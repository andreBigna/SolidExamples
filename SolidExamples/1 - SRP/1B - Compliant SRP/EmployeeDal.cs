namespace SolidExamples.SRP
{
    public class EmployeeDal : IEmployeeDal
    {
        public void PersistToDb(Employee employee)
        {
            System.Diagnostics.Debug.WriteLine("employee persisted to DB");
        }

        public Employee GetEmployee(int id)
        {
            System.Diagnostics.Debug.WriteLine("employee read from DB");

            return new Employee(id, "Tizio", 30);
        }

    }
}
