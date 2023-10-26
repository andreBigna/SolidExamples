using SolidExamples.LSP.Broken;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExamples.LSP.Compliant
{
    public abstract class BaseImagedButton : BaseButton
    {
        
        protected BaseImagedButton(Point position, string text, double width, double height) : base(position, text , width, height){}
        

        public new virtual void Render()
        {
            base.Render();
        }
    }
}
