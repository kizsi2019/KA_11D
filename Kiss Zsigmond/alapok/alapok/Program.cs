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
            //Console.WriteLine("hello világ!");
            //Console.Beep(700, 2000);
            //int be =Console.Read();
            //string be2 = Console.ReadLine();

            //Console.WriteLine(be);
            //int x = 22;
            //double y = (double)x;
            //Console.WriteLine(y);
            //0-t ír ki, mivel x int és a 4 is int
            /*int x = 3;
            Console.WriteLine(x / 4);

            //0,75 mert az x átkonvertálódik double típusra
            Console.WriteLine((double)x / 4);*/
            /*byte b = 30; //implicit konverzió ez is. int -> byte
            Console.WriteLine(b);
            int egesz = b; //implicit konvertálódik
            Console.WriteLine(egesz);
            double d = egesz; //szintén implicit mód konvertálódik
            Console.WriteLine(d);*/
            Console.WriteLine("Add meg a négyzet oldalát!");
            int a =Convert.ToInt32(Console.ReadLine());
            int kerulet = 4 * a;
            int terulet = a * a;
            Console.WriteLine("A négyzet kerulete" + kerulet);
            Console.WriteLine("A négyzet terulete" + terulet);

            Console.ReadKey();
        }
    }
}
