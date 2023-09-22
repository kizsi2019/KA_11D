using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alapok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("hello világ!");
            //Console.Beep(700, 2000);
            //int be = Console.Read();
            //Console.WriteLine(be);

            /*int x = 22;
            double y = (double)x;
            Console.WriteLine(y);*/
            //0-t ír ki, mivel x int és a 4 is int
            /*int x = 3;
            Console.WriteLine(x / 4);

            //0,75 mert az x átkonvertálódik double típusra
            Console.WriteLine((double)x / 4);*/
            /*byte b = 11; //implicit konverzió ez is. int -> byte
            int egesz = b; //implicit konvertálódik
            double d = egesz; //szintén implicit mód konvertálódik*/
            /*Console.WriteLine("Add meg a négyzet oldalát.");
            int a = Convert.ToInt32(Console.ReadLine());
            int kerulet = 4 * a;
            int terulet = a * a;
            Console.WriteLine("A négyzet kerülete: " + kerulet);
            Console.WriteLine("A négyzet területe: " + terulet);*/
            Console.WriteLine("Add meg a kör sugarát.");
            int sugar = Convert.ToInt32(Console.ReadLine());
            int kerulet = (int)(2 * sugar * 3.14);
            int terulet = (int)(sugar ^ 2 * 3.14);

            Console.ReadKey();
        }
    }
}
