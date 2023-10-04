using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @goto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Goto példa. Kilépés: CTRL+C");
            eleje:
            Console.WriteLine("Add meg a neved");
            var nev = Console.ReadLine();
            Console.WriteLine($"Szia {nev}!");
            goto eleje;
        }
    }
}
