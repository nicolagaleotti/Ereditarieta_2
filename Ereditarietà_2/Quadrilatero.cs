using System;
using System.Collections.Generic;
using System.Text;

namespace Ereditarietà_2
{
    public abstract class Quadrilatero : FiguraGeometrica
    {
        public double Lato1 { get; private set; }
        public double Lato2 { get; private set; }
        public double Lato3 { get; private set; }
        public double Lato4 { get; private set; }

        public Quadrilatero(double lato1, double lato2, double lato3, double lato4) : base()
        {
            Lato1 = lato1;
            Lato2 = lato2;
            Lato3 = lato3;
            Lato4 = lato4;
        }

        public override double CalcolaPerimetro()
        {
            return Lato1 + Lato2 + Lato3 + Lato4;
        }
    }
}
