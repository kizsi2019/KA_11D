using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            ember e = new ember("Józsi", 22, 9456);
            Console.WriteLine(e.Név);
            Console.WriteLine(e.Életkor);
            Console.WriteLine(e.Irányítószám);
            Console.ReadKey();
        }
    }
}
