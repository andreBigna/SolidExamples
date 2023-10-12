using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExamples.OCP
{
    public class Circle : IShape
    {
        public double Radius { get; set; }

        public Point Center { get; set; }

        public void Draw()
        {
            Console.WriteLine($"draws a {nameof(Circle)}");
        }
    }
}
