using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proba
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> számok = new List<int>();

            string adat;

            do
            {
                Console.Write("Adj meg számokat ");
                adat = Console.ReadLine();
                

                if (adat != "")
                {
                    int szam = int.Parse(adat);
                    számok.Add(szam);
                }
            }
            while (adat != "");

            double átlag = Math.Round(számok.Average(), 2);

            Console.WriteLine("A számok átlaga: {0}", átlag);

            Console.ReadKey();
        }
    }
}
