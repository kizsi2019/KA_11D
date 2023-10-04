using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyakorlas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Menü program");
            Console.WriteLine("Opciók:");
            Console.WriteLine("A: Kis kávé, B: Nagy kávé");
            Console.WriteLine("C: Nem iszom semmit");
            Console.Write("Kérem válasszon!: ");
            var gomb = (char)Console.Read();

            if (gomb == 'A' || gomb == 'a')
            {
                Console.WriteLine("Kis kávét választott");
            }
            else if (gomb == 'B' || gomb == 'b')
            {
                Console.WriteLine("Nagy kávét választott");
            }
            else if (gomb == 'C' || gomb == 'c')
            {
                Console.WriteLine("Kár");
            }
            else
            {
                Console.WriteLine("Nem jó gombot nyomott!");
            }
            */

            /*
            try
            {
                string szöveg = "valami szöveg";
                int szam = Convert.ToInt32(szöveg);

                Console.WriteLine(szam);
            }

            catch (FormatException ex)
            {
                Console.WriteLine("Valami történt: {0}", ex.Message);
            }
            */

            /*
            Console.WriteLine("Kettővel szorzó v. 1.0");
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

            }
            */

            /*
            int szam;
            if (int.TryParse("123", out szam))
            {
                Console.WriteLine(szam);
                //sikeres volt a feldolgozás
                //ebben a blokkban a szam változó
                //biztos, hogy helytálló értékkel rendelkezik.
            }
            */

            try
            {
                Console.Write("Add meg egy hatszög oldalát ");
                int oldal = Convert.ToInt32(Console.ReadLine());

                int kerület = oldal * 6;

                Console.WriteLine("A hatszög területe {0}", kerület + " cm");
            }

            catch(FormatException ex)
            {
                Console.WriteLine("Hiba történt: {0}", ex.Message);
            }

            Console.ReadKey();
        }
    }
}
