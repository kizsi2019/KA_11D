using dolga2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dolga2
{
    internal class FelhasznaloAdatok
    {
        
        public string Nev { get; set; }
        public decimal Havibevetel { get; set; }
        public decimal HaviKiadas { get; set; }
        public decimal Haviegyenleg => Havibevetel - HaviKiadas;
        }
       class Program
    { 

        static FelhasznaloAdatok BekerniNevet()
        {
            Console.WriteLine("Kérem adja meg a nevet: ");
            adatok.Nev = Console.ReadLine();

            adatok.HaviBevetel = BekerniOsszeget("bevetel");
            adatok.HaviKiadas = BekerniOsszeget("kiadas");

            return adatok;
        }

        static decimal Bekerniosszeget(string osszegnev)
        {
            while (true)
            {
                Console.Write($"Kerem, adja meg a havi {osszegnev} osszeget:);
                if (decimal.TryParse(Console.ReadLine(), out decimal osszeg) && osszeg >= 0)
            }
            {
                return osszeg;
            }
            else
            {
                Console.WriteLine("HIBA! Az összeg nem lehet negatív vagy nem valós szám. kérem probálja ujra");
            }
        }
    }


    static void main()
    {
        string nev = Bekerninevet();
        decimal haviBevetel = BekerniOsszeget("bevetel");
        decimal haviKiadas = BekerniOsszeget("kiadas");

        decimal egyenleg = haviBevetel - haviKiadas;

        Console.WriteLine("\nEredmeny:");
        Console.WriteLine($"Nev: {nev}");
        Console.WriteLine($"Havi bevetel: {haviBevetel} Ft");
        Console.WriteLine($"Havi kiadas: {haviKiadas} Ft");
        Console.WriteLine($"Havi egyenleg: {egyenleg} Ft");

        KiadasokStatisztika(adatok.HaviKiadas); 
    }
    {
    
    }

}
