using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_cuccok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Menü program");
            Console.WriteLine("Opciók:");
            Console.WriteLine("A: Kis kávé, B: Nagy kávé");
            Console.WriteLine("C: Nem iszom semmit");
            Console.Write("Kérem válasszon!: ");
            var gomb = (char)Console.Read();

            switch (gomb)
            {
                case 'A':
                case 'a':
                    Console.WriteLine("Kis kávét választott");
                    break;
                case 'B':
                case 'b':
                    Console.WriteLine("Nagy kávét választott");
                    break;
                case 'C':
                case 'c':
                    Console.WriteLine("KURVA ANYÁDAT THE FASZ");
                    break;
                default:
                    Console.WriteLine("Nem jó gombot nyomott!");
                    break;
            }
            
            try
            {
                string szoveg = "valami szöveg";
                int szam = Convert.ToInt32(szoveg);
                Console.WriteLine(szam);

            }
            catch (FormatException ex)
            {
                Console.WriteLine("Valami hiba történt: {0}", ex.Message);
            }



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
                Console.ReadKey();
            }
            
            int szam;
            if (int.TryParse("123", out szam))
            {
                //sikeres volt a feldolgozás
                //ebben a blokkban a szam változó
                //biztos, hogy helytálló értékkel rendelkezik.
            }      

            
            Console.WriteLine("kérek egy számocskát te csóró!!");
            try
            {
                var bevitel = Console.ReadLine();
                int szam = Convert.ToInt32(bevitel);

                if (int.TryParse(bevitel, out szam))
                {
                    int kerulet = 6 * szam;
                    Console.WriteLine("a hatszög területe " + kerulet);
                }
                else
                {
                    throw new Exception("A szám nem páros");
                }
                

            }
            catch (Exception ex)
            {
                Console.WriteLine("HIBA történt");
                Console.WriteLine(ex.Message);
            }
            
            
            Console.WriteLine("Goto példa. Kilépés: CTRL+C");
            eleje:
                Console.WriteLine("Add meg a neved");
                var nev = Console.ReadLine();
                Console.WriteLine($"Szia {nev}!");
                goto eleje;
            */

            for (int i = 5; i <= 120; i+= 5) 
            { 
                Console.WriteLine(i);
            }

            Console.ReadKey();

        }
    }
}
