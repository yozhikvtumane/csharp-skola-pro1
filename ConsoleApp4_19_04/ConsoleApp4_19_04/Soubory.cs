using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4_19_04
{
    class Soubory
    {
        public static void HledejSoubory(string path)
        {
            string[] soubory = Directory.GetFiles(path);

            foreach (var soubor in soubory)
            {
                FileInfo fi = new FileInfo(soubor);
                
                if (fi.Name == "Program.cs")
                    Console.WriteLine("{0,-25} {1,12:N0} B", fi.Name, fi.Length);
            }

            string[] slozky = Directory.GetDirectories(path);

            foreach (var slozka in slozky)
            {
                //FileInfo fi = new FileInfo(slozka);
                Console.WriteLine("{0,-25}         <DIR>", Path.GetFullPath(slozka));
                HledejSoubory(slozka);
            }
        }


    }
}
