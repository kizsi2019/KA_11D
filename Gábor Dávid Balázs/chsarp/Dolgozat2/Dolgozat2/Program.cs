using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozat2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. feladat // Gábor Dávid //

            Console.Write("Kérem adja meg a nevét: ");
            string nev = Console.ReadLine();

            Console.WriteLine("Kérem adja meg egyenlegét: ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal egyenleg));

            decimal havibevetel;
            do
            {
                Console.WriteLine("Kérem adja meg a havi bevételeit: ");
            } 
            while (!decimal.TryParse(Console.ReadLine(), out havibevetel) || havibevetel < 0);

            decimal havikiadas;
            do
            {
                Console.Write("Kérem adja meg havi kiadásait: ");
            } while (!decimal.TryParse(Console.ReadLine(), out havikiadas) || havikiadas < 0);

            Console.WriteLine(nev.ToUpper() + " egyenlege: {0:C}", egyenleg);
            Console.WriteLine(nev.ToUpper() + " legnagyobb kiadása: {0:C}", egyenleg - havikiadas);
            Console.WriteLine(nev.ToUpper() + " legkisebb kiadása: {0:C}", havibevetel - havikiadas );

            Console.ReadLine();

        }
    }
}
