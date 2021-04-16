using System;
using System.Collections.Generic;
using System.Text;

namespace Mide_tu_figura
{
    public class FigurasProps
    {
        public string imgFigura { get; set; }
        public string txtFigura { get; set; }
        public string txtFormula { get; set; }
        public string clrFigura { get; set; }

        public override string ToString()
        {
            return txtFigura;
        }
    }
}
