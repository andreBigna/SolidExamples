﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExamples.OCP
{
    /*
         * OCP: Open/Closed Principle
         *  "Software entities should be open for extension but closed for modification"
         *  Il concetto chiave di questo principio è che la logica dei nostri software dovrebbe basarsi su astrazioni. In questo modo, al cambio dei requisiti, la modifica potrà essere 
         *  fatta semplicemente aggiungendo nuovo codice, e non modificando il vecchio. Purtroppo è impossibile prevedere qualsiasi cambiamente, è possibile che un cambio di requisiti
         *  possa sempre rompere le astrazioni a cui abbiamo pensato. L'unico modo per ridurre questo rischio è utilizzare le pratiche dell'extreme programming (base dell'agile) ovvero:
         *  - TDD
         *  - Sprint di durata ridotta
         *  - "Features before infrastructure", mostrando le nuove funzionalità spesso agli stakeholders
         *  - Implementare e consolidare per prime le funzionalità core
         *  - Rilasci ravvicinati e frequenti
         */
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