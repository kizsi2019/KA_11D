using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyakorlas4
{
    internal class Program
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
                Console.WriteLine("Program vége. Nyomjon egy gombot a kilépéshez");*/

            /*
            Console.WriteLine("Hatszög kerület számító");
            Console.WriteLine("Adj meg a hatszög oldalát");

            try
            {

                var bevitel = Console.ReadLine();
                int szam = Convert.ToInt32(bevitel);

                if ((6 * szam) != 0);
                Console.WriteLine($"A szög kerülete:{szam * 6}");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }*/


            int i = 5;
            while (i <= 120)
            {
                Console.WriteLine(i);
                i += 5;
            }

            Console.WriteLine(i);


                Console.ReadKey();
        }
    }
}
