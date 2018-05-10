using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string jmeno = Console.ReadLine();

            //Console.WriteLine("Ahoj " + jmeno + "!"); 
            //Console.WriteLine("Ahoj {0}!", jmeno);
            //Console.WriteLine($"Ahoj {jmeno}!");

            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
            //Console.WriteLine($"{a} + {b} = {a + b}");

            //Console.WriteLine("Soucet - {0}", a + b);
            //Console.WriteLine("Rozdil - {0}", a - b);
            //Console.WriteLine("Soucin - {0}", a * b);
            //Console.WriteLine("Soucin - {0:N0}", a * b); // {0:N0} format cisla Number

            //Console.WriteLine("Podil - {0,5}", a / b); // dopolni na 5 znaku mezerami zleva 
            //Console.WriteLine("Podil - {0:N3}", a / (double)b);
            //Console.WriteLine("{0} + {1} = {2}", a, b, a + b);

            //Vetsi z dvou cisel
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());

            //if (a == b)
            //    Console.WriteLine("Cisla jsou stejna {0}");
            //else
            //    if (a > b)
            //        Console.WriteLine("Vetsi je a {0}", a);
            //    else
            //        Console.WriteLine("Vetsi je b {0}", b);

            //Console.ReadLine();


            //Nejvetsi z vice cisel
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //int c = Convert.ToInt32(Console.ReadLine());

            //int max = a;
            //if (b > max) max = b;
            //if (c > max) max = c;

            //Console.WriteLine("Vetsi je {0}", max);


            //Prohozeni dvou promennych
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($"{a} , {b}");
            //int p = a;
            //a = b;
            //b = p;
            //Console.WriteLine($"{a} , {b}");
            //Console.ReadLine();

            //Cyclicky posun promennych vpres (1,2,3 -> 2,3,1)
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //int c = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($"{a} , {b}, {c}");
            //int p = a;
            //a = b;
            //b = c;
            //c = p;

            //Console.WriteLine($"{a} , {b}, {c}");
            //Console.ReadLine();

            //Cyclicky posun promennych vpred (1,2,3,4  -> 2,3,4,1)
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //int c = Convert.ToInt32(Console.ReadLine());
            //int d = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($"{a}, {b}, {c}, {d}");
            //int p = a;
            //a = b;
            //b = c;
            //c = d;
            //d = p;

            //Console.WriteLine($"{a}, {b}, {c}, {d}");
            //Console.ReadLine();

            //Cyclicky posun promennych vzad (1,2,3,4  -> 2,3,4,1)
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //int c = Convert.ToInt32(Console.ReadLine());
            //int d = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($"{a}, {b}, {c}, {d}");
            //int p = d;
            //d = c;
            //c = b;
            //b = a;
            //a = p;

            //Console.WriteLine($"{a}, {b}, {c}, {d}");
            //Console.ReadLine();


            //Cyclus while

            //Console.Write("Zadej heslo: ");
            //string heslo = Console.ReadLine();

            //int i = 1;
            //while (heslo != "123" && i < 3)
            //{
            //    Console.Write("Neplatne heslo, zkuste znovu: ");
            //    heslo = Console.ReadLine();
            //    i++;
            //}

            //if (heslo == "123")
            //{
            //    Console.WriteLine("Tajna informace");

            //}
            //else {
            //    Console.WriteLine("Pocet pokusu byl prekoncen");
            //}

            //Vypsat cisla ot 1 do n
            //int n = Convert.ToInt32(Console.ReadLine());


            //for (int i = 0; i <= n; i++)
            //{
            //    Console.WriteLine(i = i + 10);
            //}

            //fibonachi a[i] = a[i - 1] + a [i - 2]
            int n = Convert.ToInt32(Console.ReadLine());

            ulong a1 = 1, a2 = 1;

            Console.WriteLine("{0,2}. = {1,25}" , 1 , a1);
            Console.WriteLine("{0,2}. = {1,25}", 2, a2);

            for (int i = 3; i <= n; i++)
            {
                ulong a3 = a1 + a2;
                Console.WriteLine("{0,2}. = {1,25:N0}", i, a3);
                a1 = a2;
                a2 = a3;
            }

            Console.ReadLine();
        }
    }
}
