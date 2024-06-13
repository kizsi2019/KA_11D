using o;
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
            Ember e = new Ember("Zsigmond", 69, 9456);
            Console.WriteLine(e.Név);
            Console.WriteLine(e.Életkor);
            Console.WriteLine(e.Írányitószám);
            Ember e2 = new Ember("KIKI", 30, 9456);
            Console.WriteLine(e.Név);
            Console.WriteLine(e.Életkor);
            Console.WriteLine(e.Írányitószám);
            Console.ReadKey();
        }
    }
}
