using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyakorlas1
{
    internal class Program
    {
        enum Hetnapjai : byte
        {
            Hetfo = 1,
            Kedd,
            Szerda,
            Csutortok,
            Pentek,
            Szombat,
            Vasarnap
        }
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
            /*int i = 5;
            while (i <= 120)
            {
                Console.Write(i);
                i += 5;
            }
            Console.ReadKey();*/
            /*int szam = -1;
            do
            {
                try
                {
                    Console.WriteLine("Adjon meg egy 1 és 10 közötti páros számot!");
                    string szoveg = Console.ReadLine();
                    szam = Convert.ToInt32(szoveg);
                }
                catch (Exception)
                {
                    szam = -1;
                }
            }
            while ((szam < 1) || (szam > 10) || ((szam % 2) != 0));

            Console.WriteLine("A megadott szám: {0}", szam);
            Console.ReadKey();*/

            /*var abc = "abcdefghijklmnopqrstuvwxyz";
            foreach (var betu in abc)
            {
                Console.Write("{0}, ", betu);
            }
            Console.ReadKey();*/

            /*Console.WriteLine("Break példa");
            for (int i = 0; i < 100; i++)
            {
                Console.Write("{0} ", i);
                if (i == 10)
                {
                    break;
                }
            }

            Console.WriteLine("Continue példa");
            int j = 30;
            while (j-- > 0)
            {
                if (j % 3 == 0)
                {
                    continue;
                }
                Console.Write("{0} ", j);
            }*/
            /*var gyumolcsok = new string[]
            {
                "alma", "körte", "szilva"
            };

            var bevitelek = new string[3];

            for (int i = 0; i < bevitelek.Length; i++)
            {
                Console.WriteLine("{0}. bevitel: ", i);
                bevitelek[i] = Console.ReadLine();
            }

            foreach (var gyumolcs in gyumolcsok)
            {
                Console.WriteLine(gyumolcs);
            }
            foreach (var bevitel in bevitelek)
            {
                Console.WriteLine(bevitel);
            }

            Console.ReadLine();*/

            /*tömb elemeinek meghatározása
            //minden sor külön zárójelet igényel
            var tomb2d = new int[,]
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            Console.WriteLine("Bejárás for ciklusokkal");
            //A length tulajdonság itt nem használható
            //mivel a tömb 2d kiterjedésű. 
            for (int i = 0; i < tomb2d.GetLength(0); i++)
            {
                for (int j = 0; j < tomb2d.GetLength(1); j++)
                {
                    Console.Write("{0} ", tomb2d[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Bejárás foreach ciklusokkal");
            foreach (var elem in tomb2d)
            {
                Console.Write("{0} ", elem);
            }
            Console.ReadLine();*/


            /*string[] tesztek = { "1", "7", "0", "99", "Hetfo", "Szerda", "Pentek", "pentek", "Hiba" };
            foreach (var teszt in tesztek)
            {
                try
                {
                    Hetnapjai nap = (Hetnapjai)Enum.Parse(typeof(Hetnapjai), teszt);
                    Console.WriteLine(nap);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("Hiba: " + ex.Message);
                }
                Hetnapjai nap2 = Hetnapjai.Hetfo; //alap érték
                Enum.TryParse(teszt, out nap2); //generikus tryparse hívás
                Console.WriteLine(nap2);
            }*/
            /*int[] randomoltszamok_Vektor = new int[10];
            Random r = new Random();
            for (int i = 0; i < randomoltszamok_Vektor.Length; i++)
            {
                randomoltszamok_Vektor[i] = r.Next(0, 100);
            } foreach (int item in randomoltszamok_Vektor)
            {
                Console.WriteLine(item);
            }*/

            /*var tomb2d = new int[,]
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };
            Random r = new Random();
            for (int i = 0; i < tomb2d.GetLength(0); i++)
            {
                for (int j = 0; j < tomb2d.GetLength(1); j++)
                {
                    Console.Write("{0} ", tomb2d[i, j] = r.Next(0, 100)) ;
                }
                Console.WriteLine();
            }
            Console.ReadLine();*/

            /*int[] randomoltszamok_Vektor = new int[3];
            Random r = new Random();
            for (int i = 0; i < randomoltszamok_Vektor.GetLength(0); i++)
            {
                randomoltszamok_Vektor[i] = r.Next(0, 100);
            }
            foreach (int item in randomoltszamok_Vektor)
            {
                Console.WriteLine(item);
            }
            Array.Sort(randomoltszamok_Vektor);
            Console.WriteLine("Rendezve:");
            foreach (int item in randomoltszamok_Vektor)
            {
                Console.WriteLine(item);
            }*/

            /*int[] randomoltszamok_Vektor = new int[3];
            Random r = new Random();
            for (int i = 0; i < randomoltszamok_Vektor.GetLength(0); i++)
            {
                randomoltszamok_Vektor[i] = r.Next(0, 100);
            }
            foreach (int item in randomoltszamok_Vektor)
            {
                Console.WriteLine(item);
            }
            Array.Reverse(randomoltszamok_Vektor);
            Console.WriteLine("Fordítottan rendezve:");
            foreach (int item in randomoltszamok_Vektor)
            {
                Console.WriteLine(item);
            }*/

            int[] randomoltszamok_Vektor = new int[3];
            for (int i = 0; i < randomoltszamok_Vektor.GetLength(0); i++)
            {
                Console.WriteLine("Adj meg egy számot: ");
                randomoltszamok_Vektor[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (int item in randomoltszamok_Vektor)
            {
                Console.WriteLine(item);
            }
            Array.Reverse(randomoltszamok_Vektor);
            Console.WriteLine("Fordítottan rendezve:");
            foreach (int item in randomoltszamok_Vektor)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();

        }
    }
}
