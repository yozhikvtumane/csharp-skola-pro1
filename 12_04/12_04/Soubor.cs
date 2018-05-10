using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_04
{
    public static class Soubor
    {
        public static void PrectiCelySoubor(string path)
        {
            string obsah = "";
            using (var sr = new StreamReader(path))
            {
                obsah = sr.ReadToEnd();
            }
                
            //sr.Close();
            Console.WriteLine(obsah);
        }

        public static void PrectiCelySouborPoRadcich(string path)
        {
            int i = 0;
            string s;
            using (var sr = new StreamReader(path))
                while ((s = sr.ReadLine()) != null)
                    
                    Console.WriteLine("{0, 2}: {1}", ++i, s);
                        //string obsah = sr.ReadToEnd();
                        //Console.WriteLine(obsah);
                    

            //sr.Close();
            
        }

        public static void ZapisDoSouboru(string path)
        {
            Console.WriteLine("Co ches zadat do souboru?");
            using (var sw = new StreamWriter(path))
            {
                while (true)
                {
                    string s = Console.ReadLine();
                    if (s == "konec") break;
                    sw.WriteLine(s);
                }
            }
        }

        public static void InfoOSouboru(string path)
        {
            FileInfo fi = new FileInfo(path);
            if (!fi.Exists)
                return;
            Console.WriteLine("Informace o souboru {0}", path);
            Console.WriteLine("Creation Time:   {0}" , fi.CreationTime);
            Console.WriteLine("Creation Time:   {0}", fi.FullName);
            Console.WriteLine("Length:   {0}", fi.Length);
        }
    }
}
