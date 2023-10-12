using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExamples.OCP
{
    public struct Square : IShape
    {
        public double Side { get; set; }

        public Point TopLeft { get; set; }

        public void Draw()
        {
            throw new NotImplementedException();
        }
    }
}
