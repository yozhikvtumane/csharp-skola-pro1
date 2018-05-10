using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4_19_04
{
    public class BinarnySoubory
    {
        static Random random = new Random();
        public static void ZapisCisla(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Create))
            using (BinaryWriter bw = new BinaryWriter(fs))
            {
                for (int i = 0; i < 20; i++)
                {
                    int x = random.Next(100);
                    bw.Write(x);
                }
            }

        }
        public static void PrecistCisla(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Open))
            using (BinaryReader br = new BinaryReader(fs))
            {
                while (true)
                {
                    int x = br.ReadInt32();
                    Console.WriteLine(x);
                }
            }
        }
    }
}
