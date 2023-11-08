using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dolgozat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("A nevét adja meg:");
            string nev = Console.ReadLine();

            List<double> jegyek = new List<double>();
            while (true)
            {
                Console.Write("Adja meg a jegyét, írjon egy 0-t ha befejezte:");
                string input = Console.ReadLine();
                if (input.ToLower() == "0")
                    break;

                if (double.TryParse(input, out double jegy))
                {
                    jegyek.Add(jegy);
                }
                else
                {
                    Console.WriteLine("Ez egy hibás jegy, adjon meg helyes jegyeket!");
                }
                if (jegyek.Count > 0)
                {
                    double atlag = Math.Round(jegyek.Average(), 2);
                    double legjobb = jegyek.Max();
                    double legrosszabb = jegyek.Min();

                    Console.WriteLine($"{nev.ToUpper()}átlaga: {atlag}");
                    Console.WriteLine($"{nev.ToUpper()}átlaga: {legjobb}");
                    Console.WriteLine($"{nev.ToUpper()}átlaga: {legrosszabb}");
                }
                else
                {
                    Console.WriteLine("Nincsen érvényes jegy megadva.");
                }
            }
        }
    }
}
