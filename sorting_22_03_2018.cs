using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApp4_22_03
{
    class Program
    {
        //http://algoritmy.net

        static Random random = new Random();
        static void Main(string[] args)
        {
            int[] a = new int[200];
            int[] b = new int[200];
            int[] c = new int[200];
            int[] d = new int[200];
            int[] e = new int[200];


            for (int i = 0; i < a.Length; i++)
            {
                int x = random.Next(a.Length);
                //a[i] = random.Next(a.Length);
                a[i] = x;
                b[i] = x;
                c[i] = x;
                d[i] = x;
                e[i] = x;



            }

            //SelectionSort(a);
            //nsertionSort(a);
            //BubbleSort(a);
            //QuickSort(a);
            Serad(a, SelectionSort);


            for (int i = 0; i < a.Length; i++)
                Console.Write("{0}, " , a[i]);

            Console.ReadLine();
        }


        static ulong PocetKroku;
        delegate void RadiciMetoda(int[] a);

        static void Serad(int[] a, RadiciMetoda metoda)
        {
            Console.WriteLine(metoda.Method.Name);
            PocetKroku = 0;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            metoda(a);
            double cas = sw.Elapsed.TotalMilliseconds;
            sw.Stop();
            Console.WriteLine("Kroku: {0}" , PocetKroku);
            Console.WriteLine("Cas:   {0} ms ", cas);
            Console.WriteLine();



        }

        private static void LinqSort(int[] a)
        {
            a = a.OrderBy(x => x).ToArray();
        }

        private static void QuickSort(int[] a)
        {
            QuickSort(a , 0 , a.Length - 1);
        }
        private static void QuickSort(int[] a, int iFrom, int iTo)
        {
            if (iFrom >= iTo) return;

            int iMez = iFrom;
            for (int i = iFrom + 1; i <= iTo; i++)
            {
                if (a[i] < a[iFrom])
                    Prohod(a , i , ++iMez);
                PocetKroku++;
            }
            Prohod(a, iFrom, iMez);
            QuickSort(a, iFrom, iMez);
            QuickSort(a, iMez + 1, iTo);
        }

        private static void BubbleSort(int[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                bool prohodil = false;
                for (int j = 0; j < a.Length - 1 - i; j++)
                    if (a[j + 1] < a[j])
                    {
                        Prohod(a, j, j + 1);
                        PocetKroku++;
                        prohodil = true;
                    }
                if (!prohodil) return;
            }
        }

        private static void InsertionSort(int[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                int j = i + 1;
                int p = a[j];
                while (j > 0 && p < a[j - 1])
                {
                    a[j] = a[j - 1];
                    j--;
                    PocetKroku++;
                }

                a[j] = p;
            }
        }

        private static void SelectionSort(int[] a)
        {
            for (int j = 0; j < a.Length; j++)
            {
                int iMin = j;

                for (int i = j + 1; i < a.Length; i++)
                {
                    if (a[i] < a[iMin])
                        iMin = i;
                        PocetKroku++;

                }

                Prohod(a, j, iMin);
            }


        }

        static void Prohod(int[] a, int i1, int i2)
        {
            int p = a[i1];
            a[i1] = a[i2];
            a[i2] = p;
        }
    }
}
