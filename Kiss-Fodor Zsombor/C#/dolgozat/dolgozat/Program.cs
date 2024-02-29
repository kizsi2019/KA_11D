using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dolgozat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 feladat
            Console.WriteLine("Diák neve:");
            string nev = Console.ReadLine();

            // Jegyek bekérése és tárolása egy listában
            List<double> jegyek = new List<double>();
            string valasz ="";
            while (valasz != "vége")
            {
                Console.Write("Kérem adja meg a jegyét (vagy 'vége' a befejezéshez): ");
                valasz = Console.ReadLine();
                if (valasz != "vége") 
                {
                    if (double.TryParse(valasz, out double jegy))
                    {
                        jegyek.Add(jegy);
                    }
                    else
                    {
                        Console.WriteLine("Hibás jegy, kérem adjon meg egy érvényes jegyet.");
                    }
                }
            }

            double atlag = Math.Round(jegyek.Average(), 2);

            double legjobb = jegyek.Max();
            double szar = jegyek.Min();

           Console.WriteLine($"{nev.ToUpper()} átlaga: {atlag}");
           Console.WriteLine("legjobb jegye:" + legjobb);
           Console.WriteLine($"legrosszabb jegye: " + szar);
           
            //2 feladat
            var szoveg = new Stack<char>();
            string adat = Console.ReadLine();
            Console.WriteLine(adat);
            /*
            //char adatchat = Convert.ToChar(adat);
            szoveg.Push(adatchat);
            foreach (char c in szoveg) 
            { 
                Console.WriteLine(c);
            }
            */
            Console.ReadLine();

            //pöcsön vágom magamat egy kocsi kulcsal
        }
    }
}
