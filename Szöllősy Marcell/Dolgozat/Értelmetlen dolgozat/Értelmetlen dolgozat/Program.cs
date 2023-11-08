using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
       
        Console.Write("Kérem adja meg a nevét: ");
        string nev = Console.ReadLine();

        
        List<double> jegyek = new List<double>();
        while (true)
        {
            Console.Write("Kérem adja meg a jegyét (vagy 'vége' a befejezéshez): ");
            string input = Console.ReadLine();
            if (input.ToLower() == "vége")
                break;

            if (double.TryParse(input, out double jegy))
            {
                jegyek.Add(jegy);
            }
            else
            {
                Console.WriteLine("Hibás jegy, kérem adjon meg egy érvényes jegyet.");
            }
        }

        if (jegyek.Count > 0)
        {
           
            double atlag = Math.Round(jegyek.Average(), 2);

           
            double legjobbJegy = jegyek.Max();
            double legrosszabbJegy = jegyek.Min();

           
            Console.WriteLine($"{nev.ToUpper()} átlaga: {atlag}");
            Console.WriteLine($"{nev.ToUpper()} legjobb jegye: {legjobbJegy}");
            Console.WriteLine($"{nev.ToUpper()} legrosszabb jegye: {legrosszabbJegy}");
        }
        else
        {
            Console.WriteLine("Nem adott meg érvényes jegyeket.");
        }
    }
}
