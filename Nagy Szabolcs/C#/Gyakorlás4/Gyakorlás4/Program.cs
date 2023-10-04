using System;
using System.Linq.Expressions;

namespace PeldaKivetelkezeles2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Kettővel szorzó v. 1.0");
            Console.WriteLine("Adjon meg egy egész páros számot!");
            try
            {
                var bevitel = Console.ReadLine();
                int szam = Convert.ToInt32(bevitel);

                if ((szam % 2) != 0)
                {
                    throw new Exception("A szám nem páros");
                }
                Console.WriteLine($"A szorzás eredménye: {szam * 2}");

            }
            catch (Exception ex)
            {
                Console.WriteLine("HIBA történt");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Program vége. Nyomjon egy gombot a kilépéshez");
                Console.ReadKey();*/
            /*Console.WriteLine("Ez egy hatszögszámító program");
             try
             {
                 Console.Write("Adja meg a hatszög oldalainak hosszát ");
                 int oldal = Convert.ToInt32(Console.ReadLine());

                 int kerulet = oldal * 6;

                 Console.WriteLine("Ahatszög kerülete: {0},", kerulet + " cm");
             }
             catch (FormatException ex)
             {
                 Console.WriteLine("Hiba történt: {0}", ex.Message);
             }


             Console.ReadKey();
            */

            /* for (int i = 100; i >= 0; i -= 4)
             {
                 Console.WriteLine(i);
             }

             Console.ReadKey();
            */

            int i = 5;
            while (i <= 120) 
            {
                Console.WriteLine(i);
                i += 5;
            }
            Console.ReadKey();
        }
    }
}


