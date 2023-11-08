using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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
            Console.Write("Adja meg a nevét: ");
            string cigany = Console.ReadLine();

            List<double> jegyek = new List<double>();
            while (true)
            {
                Console.WriteLine("Add meg a jegyed buzi, enternél vége");
                string input =
                    Console.ReadLine();
                if (input.ToLower() == "")
                    break;
                if (double.TryParse(input, out double jegy))
                {
                    jegyek.Add(jegy);
                }
                else
                {
                    Console.WriteLine("Hibás jegy. Skill issue");
                }
                }

                if (jegyek.Count > 0)
                {
                    double atlag = Math.Round(jegyek.Average(), 2);
                    double legjobbJegy = jegyek.Max();
                    double legrosszabbJegy = jegyek.Min();

                

                    Console.WriteLine($"{cigany.ToUpper()} átlaga:{atlag}");
                    Console.WriteLine($"{cigany.ToUpper()} legjobb jegye:{legjobbJegy}");
                    Console.WriteLine($"{cigany.ToUpper()} legrosszabb jegye:{legrosszabbJegy}");
                }
                else
                {
                    Console.WriteLine("Nem adott meg érvénes jegyeket.");
                }
            
        

            

            


            Console.ReadKey();
        }
    }
}
