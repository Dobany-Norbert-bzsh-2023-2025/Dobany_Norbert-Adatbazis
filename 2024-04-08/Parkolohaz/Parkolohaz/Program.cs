using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parkolohaz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            string cim = "Parkolohaz szimulacio";
            int poz = (Console.WindowWidth - cim.Length) / 2;
            Console.SetCursorPosition(poz, 5);
            Console.WriteLine(cim);
            while (true)
            {

            }
        }
    }
}
