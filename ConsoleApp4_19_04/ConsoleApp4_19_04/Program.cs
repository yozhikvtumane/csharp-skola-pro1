using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4_19_04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Soubory.HledejSoubory(@"..\..\..\..\");
            //Soubory.HledejSoubory(@"P:\Desktop\");
            //BinarnySoubory.ZapisCisla(@"..\..\..\zapis.dat");
            BinarnySoubory.PrecistCisla(@"..\..\..\zapis.dat");
            Console.ReadLine();
        }
    }
}
