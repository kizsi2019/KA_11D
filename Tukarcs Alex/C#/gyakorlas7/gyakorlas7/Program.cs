using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyakorlas7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Goto példa. Kilépés: CTRL + C"); 
        eleje:
            Console.WriteLine("Adj meg a neved");
            var nev = Console.ReadLine();
            Console.WriteLine($"Szia {nev}");
        goto eleje;
            Console.ReadKey();
        }
    }
}
