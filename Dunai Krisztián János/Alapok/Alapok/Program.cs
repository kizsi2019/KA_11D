using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alapok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* int be = Console.Read();
             string be2 = Console.ReadLine();

             Console.WriteLine(be); */

            //  int x = 22;
            //   double y= (double)x;
            //   Console.WriteLine(y);

            /*  int x = 3;
               Console.WriteLine((double)x / 4);

               Console.ReadLine(); */

         /*   Console.WriteLine("Add meg a négyzet oldalát: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int kerulet = 4 * a;
            int terulet = a * a;
            Console.Write("A négyzet kerülete: " + kerulet); 
            Console.Write("A négyzet területe: " + terulet); */

            Console.WriteLine("Add meg a négyzet oldalát: ");
            int a = Convert.ToInt32(Console.ReadLine());
            double kerulet = 3.14 * a;
            int terulet = a * a;
            Console.Write("A négyzet kerülete: " + kerulet);
            Console.Write("A négyzet területe: " + terulet); 



            Console.ReadKey();
        }
    }
}



