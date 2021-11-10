using System;

namespace Probleme_setul_1_21ex
{
    class Program
    {
        static void Main(string[] args)
        {
            // enter 0 to stop the program
            int exercice = 1;
            while (exercice != 0)
            {
                Console.Write("Wich exercice do you want to do ? Exercice: ");
                exercice = int.Parse(Console.ReadLine());
                Console.WriteLine();
            
                switch (exercice)
                {
                    case 1:
                        Exercice_1();
                        break;

                    case 2:
                        Exercice_2();
                        break;
                }
                Console.WriteLine(); Console.WriteLine();
            }
        }

        private static void Exercice_1()
        {
            int a, b;

            Console.WriteLine("ax + b = 0");
            Console.Write("a = "); a = int.Parse(Console.ReadLine());
            Console.Write("b = "); b = int.Parse(Console.ReadLine());

            if (b % a == 0)
                Console.Write("=> x = " + -b / a);
            else
                Console.Write($"=> x = {b}/{a}");
        }

        private static void Exercice_2()
        {
            int delta, x1, x2, a, b, c;
            bool nosolution = true;
            double iswholenb;

            Console.WriteLine("ax^2 + bx + c = 0");
            Console.Write("a = "); a = int.Parse(Console.ReadLine());
            Console.Write("b = "); b = int.Parse(Console.ReadLine());
            Console.Write("c = "); c = int.Parse(Console.ReadLine());

            delta = b * b - 4 * a * c;
            iswholenb = (double)(-b + (int)Math.Sqrt(delta)) / (2 * a);

            if (iswholenb % 1 == 0)
            {
                x1 = (-b + (int)Math.Sqrt(delta)) / 2 * a;
                Console.WriteLine("=> x1 = " + x1);
            }
            else
            {
                x1 = (-b + (int)Math.Sqrt(delta)) / 2 * a;
                Console.WriteLine("=> x1 = " + (-b + (int)Math.Sqrt(delta)) + "/" + 2 * a);
            }

            iswholenb = (double)(-b - (int)Math.Sqrt(delta)) / (2 * a);
            if (iswholenb % 1 == 0)
            {
                x2 = (-b - (int)Math.Sqrt(delta)) / 2 * a;
                Console.WriteLine("=> x2 = " + x2);
            }
            else
            {
                x2 = (-b - (int)Math.Sqrt(delta)) / 2 * a;
                Console.WriteLine("=> x2 = " + (-b - (int)Math.Sqrt(delta)) + "/" + 2 * a);
            }
            
            if (a * x1 * x1 + b * x1 + c == 0)
            {
                Console.WriteLine("x1 is a suitable solution");
                nosolution = false;
            }
            if(a * x2 * x2 + b * x2 + c == 0)
            {
                Console.WriteLine("x2 is a suitable solution");
                nosolution = false;
            }
            if(nosolution == true)
                Console.Write(" The solution is not a whole number or they aren't solution");
        }
    }
}
