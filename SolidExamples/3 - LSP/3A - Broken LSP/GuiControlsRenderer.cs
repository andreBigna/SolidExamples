using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExamples.LSP.Broken
{
    public static class GuiControlsRenderer
    {
        public static void RenderButtons(IEnumerable<BaseButton> buttons)
        {
            foreach (var button in buttons)
            {
                button.Render();

                //per come è fatta l'astrazione non posso renderizzare il bottone con immagine (rompendo LSP)
                //per ovviare a questo problema sarei tentato di aggiungere un type check e cast
                if (button is WindowsButton winButton)
                {
                    winButton.RenderImageFromPath();
                }
                else if (button is IosButton iosButton)
                {
                    iosButton.RenderImageBytes();
                }
            }
        }
    }
}
