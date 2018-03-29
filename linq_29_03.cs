using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4_28_03
{
    class Program
    {
        static Random random = new Random();
        static void Main(string[] args)
        {   /*

            //pole
            int[] a = new int[10];

            //seznam
            List<int> b = new List<int>();

            for (int i = 0; i < 10; i++)
                b.Add(random.Next(10));

            for (int i = 0; i < b.Count; i++)
                Console.Write("{0}, ", b[i]);
            Console.WriteLine();

            b.Insert(5, 10);
            //b.Remove(0);
            //b.RemoveAt(5);
            foreach (var x in b)
                Console.Write("{0}, ", x);
            Console.WriteLine();

            //Slovnik
            var slovnik = new Dictionary<string, string>() {
                { "table" , "stul" },
                { "air" , "vzduch"},
                { "red" , "cervena"},
            };
            slovnik.Add("car", "auto");
            slovnik["class"] = "trida";
            slovnik["mirror"] = "zrcadlo";
            slovnik["red"] = "ruda";

            //Overreni
            if (slovnik.ContainsKey("red"))
                Console.WriteLine(slovnik["red"]);


            foreach (var z in slovnik)
                Console.WriteLine("{0, 10} - {1}", z.Key, z.Value);

            Console.WriteLine("\n");

            foreach (var key in slovnik.Keys)
                Console.WriteLine("{0, 10} - {1}", key, slovnik[key]);

            var dny = new Dictionary<int, string>() {
                { 1, "pondeli"},
                { 2, "utery"},
                { 3, "streda"},
                { 4, "ctvrtek"},
                { 5, "patek"},
                { 6, "sobota"},
                { 7, "nedele"},

            };

            Console.WriteLine("\n");

            foreach (var key in dny.Keys)
                Console.WriteLine("{0, 10} - {1}", key, dny[key]);

            //LINQ  - language integrated query
            */
            int[] a = { 1, 2, 3, 4, 5, 5, 54, 7467, 568, 678, 6, 79, 679 };

            Vypis(a);

            Console.WriteLine("suma = {0}", a.Sum());
            Console.WriteLine("suma = {0}", a.Min());
            Console.WriteLine("suma = {0}", a.Max());
            Console.WriteLine("suma = {0}", a.Count());
            Console.WriteLine("suma = {0}", a.Average());

            Console.ReadLine();
        }


        static void Vypis<T>(IEnumerable<T> a)
        {
            foreach (var x in a)
            
                Console.Write("{0} , " , x);
            Console.WriteLine();
            
        }
    }
}
