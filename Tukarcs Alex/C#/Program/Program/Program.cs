using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyak3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Math.Abs(-3);
            Console.WriteLine(a);
            double b = Math.Ceiling(1.23);
            Console.WriteLine(b);
            double c = Math.Floor(1.23);
            Console.WriteLine(c);
            double d = Math.Round(1.5633, 2);
            Console.WriteLine(d);
            Console.WriteLine(Math.PI);
            Console.WriteLine(Math.E);


            var sugar = 12;
            Console.WriteLine("A kör kerülete és terület számító");
            Console.WriteLine("Kör sugara: {0}", sugar);

            var kerulet = Math.Round((Math.PI * 2 * sugar), 3);
            var terulet = Math.Round((Math.Pow(sugar, 2) * Math.PI), 3);

            Console.WriteLine("A kör kerülete: {0}", kerulet);
            Console.WriteLine("A kör területe: {0}", terulet);
            Console.ReadKey();
        }
    }
}
