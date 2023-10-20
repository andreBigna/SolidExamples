using SolidExamples.OCP;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExamples.LSP.Broken
{
    public class BaseButton
    {
        public Point Position{ get; set; }

        public string Text { get; set; }

        public double Width { get; set; }

        public double Height { get; set; }

        public BaseButton(Point position, string text, double width, double height)
        {
            Position = position;
            Text = text;
            Width = width;
            Height = height;
        }

        public void Render()
        {
            System.Diagnostics.Debug.WriteLine($"Rendering button at position {Position}, with text {Text} and size {Width}*{Height}");
        }
    }
}
