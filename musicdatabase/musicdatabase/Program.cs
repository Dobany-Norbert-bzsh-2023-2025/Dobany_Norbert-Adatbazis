using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace musicdatabase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EloadoElemzes();
            (new Program()).CimekElemzese();
        }
        static void EloadoElemzes()
        {
            string[] eloadok = new string[] { };
            foreach(string sor in File.ReadAllLines("resource/zene.txt"))
            {
                string[] reszek = sor.Split(':');
                reszek = reszek[0].Split(' ');
                string eloado = reszek[3];
                for(int i=4;i<reszek.Length;i++)
                {
                    eloado += (' ' + reszek[i]);
                }
               if(!eloadok.Contains(eloado))
                {
                    eloadok.Append(eloado);
                }
               foreach(string s in eloadok)
                {
                    Console.WriteLine(s);
                }
            }
        }
        void CimekElemzese()
        {

        }
    }
}
