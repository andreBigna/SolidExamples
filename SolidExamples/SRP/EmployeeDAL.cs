using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExamples.SRP
{
    public class EmployeeDAL : IEmployeeDAL
    {
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
