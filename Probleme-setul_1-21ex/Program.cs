﻿using System;

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

                    case 3:
                        Exercice_3();
                        break;

                    case 4:
                        Exercice_4();
                        break;

                    case 5:
                        Exercice_5();
                        break;

                    case 6:
                        Exercice_6();
                        break;

                    case 7:
                        Exercice_7();
                        break;

                    case 8:
                        Exercice_8();
                        break;

                    case 9:
                        Exercice_9();
                        break;

                    case 10:
                        Exercice_10();
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

        private static void Exercice_3()
        {
            int n, k;

            Console.WriteLine("The number n can be divided by the number k ?");
            Console.Write("n = "); n = int.Parse(Console.ReadLine());
            Console.Write("k = "); k = int.Parse(Console.ReadLine());

            if (n % k == 0)
                Console.Write("Yes he can");
            else
                Console.Write("No he can't");
        }

        private static void Exercice_4()
        {
            int an;
            Console.WriteLine("Which year do you want to know if it's a leap one ?");
            an = int.Parse(Console.ReadLine());
            if (an % 4 == 0 && an % 100 != 0 || an % 400 == 0)
                Console.Write($"{an} is a leap year");
            else
                Console.Write($"{an} is not a leap year");
        }

        private static void Exercice_5()
        {
            int nb, k, cont = 0;
            bool exist = false;

            Console.Write("Give a number: "); nb = int.Parse(Console.ReadLine());
            Console.Write("display the digit of the position k(right to left), k = ");
            k = int.Parse(Console.ReadLine());
            
            if(nb == 0 && k == 1)
            {
                Console.Write("=> " + nb % 10);
                exist = true;
            }
            while (nb != 0)
            {
                cont++;
                if(cont == k)
                {
                    Console.Write("=> " + nb % 10);
                    exist = true;
                    break;
                }
                nb /= 10;
            }
            if (exist == false)
                Console.Write("The position doesn't exist. The number is to small.");
        }

        private static void Exercice_6()
        {
            int a, b, c;
            Console.WriteLine("Can the values a, b and c be sides of a triangle ?");
            Console.Write("a = "); a = int.Parse(Console.ReadLine());
            Console.Write("b = "); b = int.Parse(Console.ReadLine());
            Console.Write("c = "); c = int.Parse(Console.ReadLine());

            if (a + b > c && a + c > b && b + c > a)
                Console.Write("Yes, they can");
            else
                Console.Write("No, they can't");
        }
        
        private static void Exercice_7()
        {
            int a, b, aux;
            Console.WriteLine("swap two numbers(with another variable)");
            Console.Write("a = "); a = int.Parse(Console.ReadLine());
            Console.Write("b = "); b = int.Parse(Console.ReadLine());
            aux = a;
            a = b;
            b = aux;
            Console.Write("a = {0} and b = {1}", a, b);
        }

        private static void Exercice_8()
        {
            int a, b;
            Console.WriteLine("swap two numbers(without another variable)");
            Console.Write("a = "); a = int.Parse(Console.ReadLine());
            Console.Write("b = "); b = int.Parse(Console.ReadLine());
            (a, b) = (b, a);
            Console.Write("a = {0} and b = {1}", a, b);
        }

        private static void Exercice_9()
        {
            int n;
            Console.WriteLine("Display all the dividers of n:");
            Console.Write("n = ");n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n / 2; i++)
                if (n % i == 0)
                    Console.WriteLine(i);
            Console.Write(n);
        }

        private static void Exercice_10()
        {
            int n;
            bool isprim = true;

            Console.Write("What number do you want to know if it's a prime one ? ");
            n = int.Parse(Console.ReadLine());

            for(int i = 2; i<=n/2;i++)
                if(n%i==0)
                {
                    isprim = false;
                    break;
                }
            if (isprim == true)
                Console.Write(n + " is a prime number");
            else
                Console.Write(n + " is not a prime number");
        }
    }
}
