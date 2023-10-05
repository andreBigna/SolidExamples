using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExamples.SRP
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Wage { get; set; }

        public Employee(int id, string name, double wage)
        {
            Id = id;
            Name = name;
            Wage = wage;
        }
    }
}
