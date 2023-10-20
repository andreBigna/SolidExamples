using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExamples.LSP.Broken
{
    public class WindowsButton : BaseButton
    {
        private string _imagePath;

        public WindowsButton(Point position, string text, double width, double height, string imagePath) : base(position, text, width, height)
        {
            _imagePath = imagePath;
        }

        public string ImagePath { get => string.IsNullOrWhiteSpace(_imagePath) ? string.Empty : _imagePath; set => _imagePath = value; }

        public void RenderImageFromPath()
        {
            System.Diagnostics.Debug.WriteLine($"Image rendered from {_imagePath}");
        }
    }
}
