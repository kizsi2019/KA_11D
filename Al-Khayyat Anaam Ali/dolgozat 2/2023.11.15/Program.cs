 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023._11._15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kérem, adja meg a nevét: ");
            string nev = Console.ReadLine();

            Console.Write("Kérem adja meg az egyenlegét: ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal egyen))
            {
                Console.WriteLine("Hibás formátum. Kérem, adjon meg egy érvényes számot.");
                return;
            }

            Console.Write("Kérem adja meg a havi bevételeit: ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal bevetel)) 
            {
                Console.WriteLine("Hibás formátum. Kérem, adjon meg egy érvényes számot.");
                return;
            }

            Console.Write("Kérem, adja meg a havi kiadásait: ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal kiadas))
            {
                Console.WriteLine("Hibás formátum. Kérem, adjon meg egy érvényes számot.");
                return;
            }

            decimal egyenleg = bevetel - kiadas;

            Console.WriteLine($"{nev.ToUpper()} egyenlege : {egyenleg} {nev.ToUpper()} legnagyobb  kiadása: {kiadas} {nev.ToUpper()} legkissebb kiadása: {kiadas}");
        }
    }
}
