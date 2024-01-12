using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace op1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Ember e = new Ember("Zsigmond", 69, 9456);
            Console.WriteLine(e.Név);
            Console.WriteLine(e.Életkor);
            Console.WriteLine(e.Irányítószám);
            Ember e2 = new Ember("Péter", 70, 9456);
            Console.WriteLine(e.Név);
            Console.WriteLine(e.Életkor);
            Console.WriteLine(e.Irányítószám);
            Console.ReadKey();
        }
    }
}
