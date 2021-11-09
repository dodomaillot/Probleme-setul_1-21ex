using System;

namespace Probleme_setul_1_21ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Wich exercice do you want to do ? Exercice: ");
            int exercice = int.Parse(Console.ReadLine());
            Console.WriteLine();
            switch (exercice)
            {
                case 1:
                    Exercice_1();
                    break;
            }
        }

        private static void Exercice_1()
        {
            int a, b;
            Console.WriteLine("ax + b = 0");
            Console.Write("a = "); a = int.Parse(Console.ReadLine());
            Console.Write("b = "); b = int.Parse(Console.ReadLine());
            Console.Write("=> x = " + -b / a);
        }

    }
}
