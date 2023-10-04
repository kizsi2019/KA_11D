using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyakorlás_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*/int a = Math.Abs(-3);
            Console.WriteLine(args);
            double b = Math.Ceiling(1.23);
            Console.WriteLine(b);
            double c = Math.Floor(1.23);
            Console.WriteLine(c);
            double d = Math.Round(1.56);

            Console.ReadKey();*/

            /*/ var sugar = 12; 
             Console.WriteLine("Kör kerület és terület számító.");
             Console.WriteLine("Kör sugara: {0}", sugar);

             var kerulet = Math.Round((Math.PI * 2 * sugar), 3);
             var terulet = Math.Round((Math.Pow(sugar, 2) * Math.PI)3);

             Console.WriteLine("A kör kerülete: {0}", kerulet);
             Console.WriteLine("A kör területe: {0}", terulet);

             Console.ReadLine(); */

            static void Main(string[] args)
            {
                Console.WriteLine("Kérem adjon meg egy számot!");
                var bevitel = Console.ReadLine();

                int x = Convert.ToInt32(bevitel);

                if (x >= 20) Console.WriteLine("Nagyobb, vagy egyenlő , mint 20");
                else if (x >= 10) Console.WriteLine("Nagyobb, vagy egyenlő, mint 10");
                else Console.WriteLine("Kisebb, mint 10");

                //Komplex feltétel, zárójelezés fontos!
                if (((x % 2) == 0) && (x > 0))
                {
                    Console.WriteLine("A megadott szám páros és nem nulla");
                }
                else Console.WriteLine("Páratlan vagy nulla");

                Console.ReadKey();
            }
    }
}
