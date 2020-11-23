using System;
using System.Collections.Generic;
using System.Text;

namespace Ereditarietà_2
{
    public class Rettangolo : Quadrilatero
    {
        public Rettangolo(double _base, double altezza) : base(_base, altezza, _base, altezza) { }

        public override double CalcolaArea()
        {
            return Lato1 * Lato2;
        }
    }
}
