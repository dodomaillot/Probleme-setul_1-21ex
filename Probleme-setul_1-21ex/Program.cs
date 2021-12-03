using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


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

                    case 11:
                        Exercice_11();
                        break;

                    case 12:
                        Exercice_12();
                        break;

                    case 13:
                        Exercice_13();
                        break;

                    case 14:
                        Exercice_14();
                        break;

                    case 15:
                        Exercice_15();
                        break;

                    case 16:
                        Exercice_16();
                        break;

                    case 17:
                        Exercice_17();
                        break;

                    case 18:
                        Exercice_18();
                        break;

                    case 19:
                        Exercice_19();
                        break;

                    case 20:
                        Exercice_20();
                        break;

                    case 21:
                        Exercice_21();
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

        private static void Exercice_11()
        {
            int n, reverse = 0, p = 1;
            Console.Write("What number do you want to reverse ? ");
            n = int.Parse(Console.ReadLine());
            Console.Write("The reverse of " + n);
            while (n != 0)
            {
                if (n / 10 != 0)
                    reverse = (reverse * p + n % 10) * 10;
                else
                    reverse = reverse * p + n % 10;
                n /= 10;
            }
            Console.Write(" is " + reverse);
        }

        private static void Exercice_12()
        {
            int n, a, b, cont = 0;
            
            Console.WriteLine("How many numbers are divisible by n in the interval [a,b] ?");
            Console.Write("n = "); n = int.Parse(Console.ReadLine());
            Console.Write("a = "); a = int.Parse(Console.ReadLine());
            Console.Write("b = "); b = int.Parse(Console.ReadLine());

            if (a > b)
                (a, b) = (b, a);
            for (int i = a; i <= b; i++)
                if (i % n == 0)
                    cont++;

            if (cont == 0)
                Console.Write("No number is divisible by " + n + " in the interval");
            else
                Console.Write("They are " + cont + " divible by " + n + " in the interval");
        }

        private static void Exercice_13()
        {
            int year1, year2, nr = 0;

            Console.WriteLine("How many leaps years are between the year1 and year2 ?");
            Console.Write("year1 = "); year1 = int.Parse(Console.ReadLine());
            Console.Write("year2 = "); year2 = int.Parse(Console.ReadLine());

            if (year1 > year2)
                (year1, year2) = (year2, year1);
            for (int i = year1; i <= year2; i++)
                if (i % 4 == 0 && i % 100 != 0 || i % 400 == 0)
                    nr++;
            Console.Write("They are/is " + nr + " leap(s) year(s)");
        }

        private static void Exercice_14()
        {
            int n, rem, inv = 0;
            Console.WriteLine("Is the number n a palindrom number ?");
            Console.Write("n = "); n = int.Parse(Console.ReadLine());

            rem = n;
            while(rem!=0)
            {
                inv = (inv + rem % 10) * 10;
                rem /= 10;
            }
            inv /= 10;
            if (inv == n)
                Console.Write("Yes, it is");
            else
                Console.Write("No, it isn't");
        }

        private static void Exercice_15()
        {
            int a, b, c;
            Console.WriteLine("Give 3 numbers which will be arranged in ascending order");
            Console.Write("a = "); a = int.Parse(Console.ReadLine());
            Console.Write("b = "); b = int.Parse(Console.ReadLine());
            Console.Write("c = "); c = int.Parse(Console.ReadLine());

            if (a > b)
                (a, b) = (b, a);
            if (b > c)
                (b, c) = (c, b);
            if (a > b)
                (a, b) = (b, a);
            Console.Write($"{a} {b} {c}");
        }

        private static void Exercice_16()
        {
            int a, b, c, d, e;
            Console.WriteLine("Give 5 numbers which will be arranged in ascending order");
            Console.Write("a = "); a = int.Parse(Console.ReadLine());
            Console.Write("b = "); b = int.Parse(Console.ReadLine());
            Console.Write("c = "); c = int.Parse(Console.ReadLine());
            Console.Write("d = "); d = int.Parse(Console.ReadLine());
            Console.Write("e = "); e = int.Parse(Console.ReadLine());

            while(a>b || b>c || c>d || d>e)
            {
                if (a > b)
                    (a, b) = (b, a);
                if (b > c)
                    (b, c) = (c, b);
                if (c > d)
                    (c, d) = (d, c);
                if (d > e)
                    (d, e) = (e, d);
            }
            Console.Write("{0} {1} {2} {3} {4}", a, b, c, d, e);
        }

        private static void Exercice_17()
        {
            int a, b, gcd, a2, b2;
            Console.WriteLine("The greatest common number and the least common multiple of two numbers a and b");
            Console.Write("a = "); a = int.Parse(Console.ReadLine());
            Console.Write("b = "); b = int.Parse(Console.ReadLine());

            if (a < b)
                (a, b) = (b, a);
            a2 = a;
            b2 = b;
            gcd = a % b;
            a = b;
            b = gcd;
            while(gcd != 0)
            {
                gcd = a % b;
                a = b;
                b = gcd;
            }
            Console.Write("gcd = "+ a + "; lcm = " + a2*b2/a);

        }

        private static void Exercice_18()
        {
            int d = 2, n, p;
            Console.WriteLine("Decomposition into prime factors of a number n");
            Console.Write("n = "); n = int.Parse(Console.ReadLine());
            while(n>1)
            {
                p = 0;
                while(n%d==0)
                {
                    p++;
                    n /= d;
                }
                if (p > 0)
                    Console.Write($"{d}^{p}; ");
                d++;
            }
        }

        private static void Exercice_19()
        {
            int a, b, n;
            bool itis = true;
            Console.WriteLine("Determine if a number n is formed with only 2 repeating digits");
            Console.Write("n = "); n = int.Parse(Console.ReadLine());
            a = n % 10; n /= 10;
            b = a;
            while(a==b)
            {
                b = n % 10;
                n /= 10;
            }
            while (n != 0)
            {
                if (n % 10 != a && n % 10 != b)
                {
                    itis = false;
                }
                n /= 10;
            }
            if(itis == false)
                Console.Write("it isn\'t");
            else
                Console.Write("it is");
        }

        private static void Exercice_20()
        {
            //this program is limited to only 6 repetitiv numbers

            int nominator, denominator, rest, nbdeci = 0, p = 1;
            bool isperiod = false;
            Console.WriteLine("Display a fraction in decimal form and put the repeating numbers in brackets.");
            Console.Write("nominator: "); nominator = int.Parse(Console.ReadLine());
            Console.Write("denominator: "); denominator = int.Parse(Console.ReadLine());
            Console.Write($"{nominator}/{denominator} = {nominator/denominator},");
            
            List<int> remenber_rest = new List<int>();
            rest = nominator % denominator;
            remenber_rest.Add(rest);
            if (rest == 0)
                Console.Write("0");
            int i = 0;

            while (rest != 0 || i!=0)
            {
                nbdeci += rest * 10 / denominator * p;
                p *= 10;
                rest = rest * 10 % denominator;
                if (remenber_rest.Contains(rest))
                {
                    i = 0;
                    while(nbdeci != 0)
                    {
                        if (remenber_rest[i] == rest)
                        {
                            Console.Write("(");
                            isperiod = true;
                        }
                        
                        Console.Write(nbdeci % 10);
                        nbdeci /= 10;
                        i++;
                    }
                    if(isperiod == true)
                        Console.Write(")");
                    break;
                }
                remenber_rest.Add(rest);
                i++;
            }
        }

        private static void Exercice_21()
        {
            int nb, prop;
            var rand = new Random();
            nb = rand.Next(1, 1025);
            
            Console.WriteLine("Try to find a number between 1 and 1024 by answering the question: The number is bigger or equal than x ?");

            do
            {
                Console.Write("The number is bigger, smaller or equal than x ? Where x = ");
                prop = int.Parse(Console.ReadLine());
                if (prop > nb)
                    Console.WriteLine("The number you are trying to find is smaller");
                else if (prop < nb)
                    Console.WriteLine("The number you are trying to find is bigger");
                else
                    Console.Write("Great !! You found the number !!");
            } while (prop != nb);
        }
    }
}
