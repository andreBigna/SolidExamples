using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExamples.BrokenOCP
{
    public class ShapesDrawer
    {
        public void DrawShapes(IEnumerable<object> shapes)
        {
            foreach (object shape in shapes)
            {
                if (shape is Square square)
                {
                    DrawSquare(square);
                }
                else if (shape is Circle circle)
                {
                    DrawCircle(circle);
                }
            }
        }

        private void DrawSquare(Square square)
        {
            Console.WriteLine($"draws a {nameof(Square)}");
        }

        private void DrawCircle(Circle circle)
        {
            Console.WriteLine($"draws a {nameof(Circle)}");
        }
    }
}
