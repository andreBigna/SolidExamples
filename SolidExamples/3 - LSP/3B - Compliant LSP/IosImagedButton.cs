using SolidExamples.LSP.Broken;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExamples.LSP.Compliant
{
    public class IosImagedButton : BaseImagedButton
    {
        private readonly IosButton _iosButton;

        public IosImagedButton(Point position, string text, double width, double height, byte[] image) : base(position, text, width, height)
        {
            _iosButton = new IosButton(position, text, width, height, image);
        }

        public override void Render()
        {
            base.Render();
            _iosButton.RenderImageBytes();
        }
    }
}
