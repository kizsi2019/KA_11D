using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Console.WriteLine("hello világ!");
            Console.Beep(500, 2000);
            int be = Console.Read();
            string be2 = Console.ReadLine();
            Console.WriteLine(be);
            int x = 22;
            double y = (double)x;
            Console.WriteLine(y);
            0-t ír ki, mivel x int és a 4 is int
            int x = 3;
            Console.WriteLine(x / 4);
            0,75 mert az x átkonvertálódik double típusra
            Console.WriteLine((double)x / 4);
            byte b = 11;
            Console.WriteLine(b);
            int egész = b;
            Console.WriteLine(egész);
            double d = egész;
            Console.WriteLine(d);
            Console.WriteLine("kérek egy számocskát te csóró!!");
            int x = Convert.ToInt32(Console.ReadLine());
            int terulet = x * x;
            int kerulet = 4 * x;
            Console.WriteLine("a négyzet területe " + terulet);
            Console.WriteLine("a négyzet területe " + kerulet);
            */

            Console.WriteLine("kérek egy számocskát te csóró!!");
            double r = Convert.ToInt32(Console.ReadLine());
            double terulet = (r*r) * Math.PI;
            double kerulet = 2 * r * Math.PI;
            Console.WriteLine("a kör területe " + terulet);
            Console.WriteLine("a kör területe " + kerulet);

            Console.ReadKey();
        }
    }
}
