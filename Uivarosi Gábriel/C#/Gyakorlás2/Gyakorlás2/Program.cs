using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyakorlás2
{
    internal class Program
    {
        static void Main(string[] args)
        {   /*
            int b = Math.Abs(-3);
            Console.WriteLine(b);
            double c = Math.Ceiling(1.23);
            Console.WriteLine(c);
            double d = Math.Floor(1.23);
            Console.WriteLine(d);
            double t = Math.Round(1.23);
            Console.WriteLine(t);
            double g = Math.Round(1.339231325213331, 0);

            Console.WriteLine(g);
            Console.WriteLine(Math.PI);
            Console.WriteLine(Math.E);
            Console.ReadKey();
            
            

            var sugar = 12; 
            Console.WriteLine("Kör kerület és terület számító.");
            Console.WriteLine("Kör sugara: {0}", sugar);

            var kerulet = Math.PI * 2 * sugar;
            var terulet = Math.Pow(sugar, 2) * Math.PI;
            
            Console.WriteLine("A kör kerülete: {0}", Math.Round(kerulet, 2));
            Console.WriteLine("A kör területe: {0}", Math.Round(terulet, 2));

            Console.ReadLine();
            
            
            int max = Math.Max(10, 23);
            Console.WriteLine(max);
            
        

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

            
            */
             bool Teszt1()
            {
                Console.WriteLine("Teszt1 kiértékelése...");
                return false;
            }

             bool Teszt2()
            {
                Console.WriteLine("Teszt2 kiértékelése...");
                return true;
            }

                string target = "https://www.youtube.com/watch?v=9vCb_ZopT4A";
            

            System.Diagnostics.Process.Start(target);
            if (Teszt1() & Teszt2())
            {
                //Mindkét metódus lefut a tesztelés közben
            }
            Console.WriteLine();

            if (Teszt2() | Teszt1())
            {
                //Mindkét metódus lefut a tesztelés közben
            }
            Console.WriteLine();

            if (Teszt1() && Teszt2())
            {
                //Teszt2 nem hívódik meg
            }
            Console.WriteLine();

            if (Teszt2() || Teszt1())
            {
                //Teszt1 nem hívódik meg
            }
            Console.ReadLine();

            Console.ReadLine();
        }
    }
}
