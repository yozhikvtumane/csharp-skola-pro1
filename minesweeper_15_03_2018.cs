using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static Random random = new Random();

        static void Main(string[] args)
        {
            //Deklarace pole
            int n = 10, m = 10, pocetMin = 10;
            int[,] pole = new int[n, m];

            //0-nic, 1-8 cislo, 9 - mina, zaporana verze cisla (pro 0 je 10) - odkryte pole
            //Rozmisteni min

            for (int k = 0; k < pocetMin; k++)
            {
                int i = random.Next(n);
                int j = random.Next(m);
                while (pole[i, j] == 9) {
                    i = random.Next(n);
                    j = random.Next(m);
                }
                pole[i, j] = 9;
                for (int y = -1; y <= 1; y++)
                    for (int x = -1; x <= 1; x++)
                        if (i + y >= 0 && x + j >= 0 && i + y < n && j + x < m && pole[i + y, j + x] != 9)
                            pole[i + y, j + x]++;

            }


            VypisPole(pole);

            //Hra

            short konec = 0;
            while (konec == 0)
            {
                int x = -1, y = -1;
                bool platneSouradnice = false;
                while (!platneSouradnice)
                    try
                    {
                        Console.Write("x: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        Console.Write("y: ");
                        y = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        if (x >= 0 && x < m && y >= 0 && y < n)
                            if (pole[y, x] >= 0)
                                platneSouradnice = true;
                            else
                                Console.WriteLine("Pola na zad... je jiz odkryto");
                        else
                            Console.WriteLine("Byly zadany souradnice mimo rozsah pole....");
                    }
                    catch
                    {
                        Console.WriteLine("musi byt platne cele cislo...");                        
                    }
                //Odkryti pole 
                if (pole[y, x] == 9)
                {
                    pole[x, y] = -9;
                    VypisPole(pole);
                    for (int i = 0; i < n; i++)
                        for (int j = 0; j < m; j++)
                            if (pole[i, j] >= 1 && pole[i, j] <= 9)
                                pole[i, j] *= -1;
                            else if (pole[i, j] == 0)
                                pole[i, j] = -10;

                    konec = -1;
                }
                else
                    Odkryj(y , x, pole);
                VypisPole(pole);
                if (konec == 0 && JeVseOdkryto(pole))
                    konec = 1;
            }

            Console.ReadLine();
        }

        static bool JeVseOdkryto(int[,] pole)
        {
            for (int i = 0; i < pole.GetLength(0); i++)
                for (int j = 0; j < pole.GetLength(1); j++)
                    if (pole[i, j] >= 0 && pole[i, j] != 9)
                        return false;
            return true;
        }

        private static void Odkryj(int i, int j, int[,] pole)
        {
            if (i >= 0 && j >= 0 && i < pole.GetLength(0) && j < pole.GetLength(1))
                if (pole[i, j] == 0)
                {
                    pole[i, j] = -10;
                    //Odkryt vsechny sousedy
                    for (int y = -1; y <= 1; y++)
                        for (int x = -1; x <= 1; x++)
                            Odkryj(i + y, j + x , pole);
                }
                else if (pole[i, j] > 0 && pole[i, j] < 9)
                    pole[i, j] *= -1;
        }

        static void VypisPole(int[,] pole)
        {

            Console.Write("  |");
            for (int j = 0; j < pole.GetLength(1); j++)
            
                Console.Write(" {0}", j);
                Console.WriteLine();
                Console.WriteLine("--+-".PadRight(2*pole.GetLength(1)+4, '-'));
               
            
            for (int i = 0; i < pole.GetLength(0); i++)

            {
                Console.Write("{0,2}|" , i);
                for (int j = 0; j < pole.GetLength(1); j++)
                {
                    Console.Write(" ");
                    if (pole[i, j] >= 0)
                        VypisZnakSBarvou('#', ConsoleColor.Black);
                    else if (pole[i, j] == -9)
                        VypisZnakSBarvou('X', ConsoleColor.Red);
                    else if (pole[i, j] == -10)
                        VypisZnakSBarvou('0', ConsoleColor.DarkCyan);
                    else
                        VypisZnakSBarvou((-pole[i, j]).ToString()[0], ConsoleColor.DarkGray);

                }
                Console.WriteLine();
                
            }
            Console.WriteLine();
        }

        static void VypisZnakSBarvou(char znak, ConsoleColor barva)
        {
            Console.BackgroundColor = barva;
            Console.Write(znak);
            Console.BackgroundColor = ConsoleColor.Black;

        }
    }
}
