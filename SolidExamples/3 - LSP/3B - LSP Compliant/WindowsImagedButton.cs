using SolidExamples.LSP.Broken;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExamples.LSP.Compliant
{
    public class WindowsImagedButton : BaseImagedButton
    {
        private readonly WindowsButton _windowsButton;

        public WindowsImagedButton(Point position, string text, double width, double height, string imagePath) : base(position, text, width, height)
        {
            _windowsButton = new WindowsButton(position, text, width, height, imagePath);
        }

        public override void Render()
        {
            base.Render();
            _windowsButton.RenderImageFromPath();
        }
    }
}
