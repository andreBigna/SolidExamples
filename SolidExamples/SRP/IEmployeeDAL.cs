using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExamples.SRP
{
    public interface IEmployeeDAL
    {
        void PersistToDb(Employee employee);

        Employee GetEmployee(int id);
    }
}
