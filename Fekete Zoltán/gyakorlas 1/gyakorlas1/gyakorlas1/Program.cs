using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyakorlas1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Menü program");
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
            Console.ReadKey();*/
            /*try
            {
                string szoveg = "valami szöveg";
                int szam = Convert.ToInt32(szoveg);
                Console.WriteLine(szam);

            }
            catch (FormatException ex)
            {
                Console.WriteLine("Valami hiba történt: {0}", ex.Message);
            }

            Console.ReadKey();*/
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
                Console.ReadKey();
            }*/
            /*int szam;
            if (int.TryParse("123", out szam))
            {
                //sikeres volt a feldolgozás
                //ebben a blokkban a szam változó
                //biztos, hogy helytálló értékkel rendelkezik.
            }*/
            /*Console.WriteLine("Adja meg a hatszög oldalait!");
            try
            {
                var kerulet = Console.ReadLine();
                int szam = Convert.ToInt32(kerulet);

                Console.WriteLine($"A hatszög kerülete: {szam * 6}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hiba történt.");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Program vége. Nyomjon egy gombot a kilépéshez.");
                Console.ReadKey();
            }*/
            /*Console.WriteLine("Goto példa. Kilépés: CTRL+C");
        eleje:
            Console.WriteLine("Add meg a neved");
            var nev = Console.ReadLine();
            Console.WriteLine($"Szia {nev}!");
            goto eleje;*/
            /*for (int i = 100; i >= 0; i -= 4)
            {
                Console.WriteLine("{0}, ", i);
            }
            Console.ReadKey();*/
            int i = 5;
            while (i <= 120)
            {
                Console.Write(i);
                i += 5;
            }
            Console.ReadKey();
        }
    }
}
