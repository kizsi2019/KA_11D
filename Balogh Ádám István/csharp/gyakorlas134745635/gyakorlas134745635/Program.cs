using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyakorlas134745635
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
                     Console.WriteLine("Kár");
                     break;
                 default:
                     Console.WriteLine("Nem jó gombot nyomott!");
                     break;
             }

            string szoveg = "valami szöveg";
            int szam = Convert.ToInt32(szoveg);
            Console.WriteLine(szam); 
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

            try
            {
                Console.Write("Add meg a hatszög oldalát.");
                int oldal = Convert.ToInt32(Console.ReadLine());

                int kerület = oldal * 6;

                Console.WriteLine("A hatszög terulete {0}", kerület + " cm");
            }

            catch (FormatException ex)
            {
                Console.WriteLine("Hiba történt: {0}", ex.Message);
            Console.WriteLine("\n100 -> 0, minden 4.");
            for (int i = 100; i >= 0; i -= 4)
            {
                Console.Write("{0}, ", i);
            }
            Console.ReadKey();*/
            int i = 5;
            while (i <= 120)
            {
                Console.Write(i);
                i+=5;
            }
            Console.ReadKey();
        }
    }
}
