using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static Random random = new Random();
        static void Main(string[] args)
        {
            int[] a = new int[10];
            int z = 0;
            //for (int i = 0; i < a.length; i++)
            //{
            //    a[i] = Convert.ToInt32(Console.ReadLine);
            //}
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = random.Next(100);
            }
            VypisPosloupnost(a);
            //POcet sudych clenu
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0 && a[i] != 0)
                {
                    z++;
                }
            }

            //Nalezeni min hodnoty
            int min = a[0];

            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] < min) {
                    min = a[i];
                }
            }

            int pocetMinim = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == min)
                {
                    pocetMinim++;
                }
            }


            //Prvni minimum
            int iMin = 0;

            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] < a[iMin])
                {
                    iMin = i;
                }
            }

            //Odebrani clena posloupnosti
            Console.WriteLine("Index to erase: ");
            int k = Convert.ToInt32(Console.ReadLine());

            for (int i = k; i < a.Length - 1; i++)
            {
                a[i] = a[i + 1];
            }
            Array.Resize(ref a, a.Length - 1);

            //vlozeni clena posloupnosti
            Console.WriteLine("Index to add: ");
            int zz = Convert.ToInt32(Console.ReadLine()); //3
            Console.WriteLine("Value of index to add: ");
            int h = Convert.ToInt32(Console.ReadLine());

            Array.Resize(ref a, a.Length + 1);
            for (int i = a.Length - 1; i > zz; i--)
            {
                a[i] = a[i - 1];
            }
            a[zz] = h;

            VypisPosloupnost(a);
            Console.WriteLine("Pocet sudych cisel je: {0}" , z);
            Console.WriteLine("Min hodnota je {0}", min);
            Console.WriteLine("Pocet minim je {0}" , pocetMinim);
            Console.WriteLine("Minimum = {0} a poprve na indexu {1}", a[iMin] , iMin);
            Console.ReadLine();
        }

        static void VypisPosloupnost(int[] a) {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("{0}, ", a[i]);

            }
            Console.WriteLine();
        }
    }
}
