using System;
using Ereditarietà_2;

namespace Prova
{
    class Program
    {
        static void Main(string[] args)
        {
            FiguraGeometrica f1 = new Rettangolo(5, 3);
            FiguraGeometrica f2 = new Rombo(4, 2, 3);
            FiguraGeometrica f3 = new Triangolo(3, 4, 5, 4);
            Console.WriteLine("Rettangolo");
            Console.WriteLine(f1.CalcolaPerimetro() + "\n" + f1.CalcolaArea());
            Console.WriteLine("Rombo");
            Console.WriteLine(f2.CalcolaPerimetro() + "\n" + f2.CalcolaArea());
            Console.WriteLine("Triangolo");
            Console.WriteLine(f3.CalcolaPerimetro() + "\n" + f3.CalcolaArea());
        }
    }
}
