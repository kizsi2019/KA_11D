using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Január_2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ember e = new Ember("Józsi", 22, 4376);
            Console.WriteLine(e.Név);
            Console.WriteLine(e.Életkor);
            Console.WriteLine(e.Iránysz);
            Ember f = new Ember("Konor", 18, 1048);
            Console.WriteLine(f.Név);
            Console.WriteLine(f.Életkor);
            Console.WriteLine(f.Iránysz);
            Console.ReadKey();
        }
    }
}
