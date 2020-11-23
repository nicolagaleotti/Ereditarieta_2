using System;
using System.Collections.Generic;
using System.Text;

namespace Ereditarietà_2
{
    public class Rombo : Quadrilatero
    {
        public double DiagonaleMaggiore { get; private set; }
        public double DiagonaleMinore { get; private set; }
        public Rombo(double lato, double diagonaleMaggiore, double diagonaleMinore) : base(lato, lato, lato, lato)
        {
            DiagonaleMaggiore = diagonaleMaggiore;
            DiagonaleMinore = diagonaleMinore;
        }

        public override double CalcolaArea()
        {
            return (DiagonaleMaggiore * DiagonaleMinore) / 2;
        }
    }
}
