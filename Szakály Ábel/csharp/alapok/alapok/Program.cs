using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alapok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello világ!");
            //Console.Beep(120, 2000);
            //int be =Console.Read();
            //string  be2 =Console.ReadLine();
            //Console.WriteLine(be);
            //int x = 22;
            //double y = (double)x;
            //Console.WriteLine(y);

            //int x = 3;
            //Console.WriteLine(x / 4);

            //Console.WriteLine((double)x / 4);
            //byte b = 11;
            //Console.WriteLine(b);
            //int egesz = b;
            //Console.WriteLine(egesz);
            //double d = egesz;
            //Console.WriteLine(d);

            /*Console.WriteLine("Kérek a négyzet oldalát");
            int a = Convert.ToInt32(Console.ReadLine());
            int kerulet = 4 * a;
            int terulet = a * a;
            Console.WriteLine("A négyzet kerulete " + kerulet);
            Console.WriteLine("A négyzet területe " + terulet); */

            Console.WriteLine("Kérem a kör sugarát");
            int a = Convert.ToInt32(Console.ReadLine());

            double kerulet = 2 * a * 3.14;
            double terulet = a * a * 3.14;








            Console.ReadKey();
        }
    }
}
