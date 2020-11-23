using System;
using System.Collections.Generic;
using System.Text;

namespace Ereditarietà_2
{
    public class Triangolo : FiguraGeometrica
    {
        public double Base { get; private set; }
        public double Lato2 { get; private set; }
        public double Lato3 { get; private set; }
        public double Altezza { get; private set; }

        public Triangolo(double _base, double lato2, double lato3, double altezza) : base()
        {
            Base = _base;
            Lato2 = lato2;
            Lato3 = lato3;
            Altezza = altezza;
        }

        public override double CalcolaPerimetro()
        {
            return Base + Lato2 + Lato3;
        }

        public override double CalcolaArea()
        {
            return (Base * Altezza) / 2;
        }
    }
}
