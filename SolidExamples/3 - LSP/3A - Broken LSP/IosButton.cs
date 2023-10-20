using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExamples.LSP.Broken
{
    public class IosButton : BaseButton
    {
        public IosButton(Point position, string text, double width, double height, byte[] image) : base(position, text, width, height)
        {
            _image = image;
        }

        private readonly byte[] _image;

        public void RenderImageBytes()
        {
            using (var ms = new MemoryStream(_image))
            {
                //creating the image
            }
            System.Diagnostics.Debug.WriteLine($"Image rendered");
        }
    }
}
