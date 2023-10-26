using SolidExamples.LSP.Broken;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExamples.LSP.Compliant
{
    public static class GuiButtonsRenderer
    {

        public static void RenderButtons(IEnumerable<BaseImagedButton> baseImagedButtons)
        {
            foreach (var button in baseImagedButtons)
            {
                button.Render();
            }
        }


    }
}
