using System;

namespace PeldaIf
{
    class Program
    {
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
