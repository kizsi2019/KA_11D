using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramozasiTetelek_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            
            // Beolvasás
            StreamReader sr = new StreamReader("vegeredmeny.txt");
            List<string> eredmeny = new List<string>();
            while (!sr.EndOfStream)
            {
                eredmeny.Add(sr.ReadLine());
            }
            sr.Close();

            // kiválasztás tétele
            Console.WriteLine("Adja meg a versenyző nevét: ");
            string nev = Console.ReadLine();
            int i = 0;
            while (i < eredmeny.Count && eredmeny[i] != nev)
            {
                i++;
            }
            Console.WriteLine("{0} nevű versenyző {1}. lett", nev, i + 1);

            */

            /*
            
            int[] beolvasas = new int[20];
            for (int i = 0; i < 20; i++)
            { // bekérés a felhasználótól
                Console.WriteLine("Adja meg a {0}. számot: ", i + 1);
                beolvasas[i] = int.Parse(Console.ReadLine());
            }

            // Keresés tétele
            int j = 0;
            while (j < beolvasas.Length && beolvasas[j] % 3 != 0)
            {
                j++;
            }
            if (j < beolvasas.Length) Console.WriteLine("3mal osztható számot {0}.-ra vitt be!", j + 1);
            else Console.WriteLine("Nem adott meg 3-mal osztható számot!");

            */


            int[] rendezettTomb = new int[] { 10, 15, 18, 25, 31, 49, 60, 72, 80, 83};
            // Logratimus keresés
            int alsohatar = 0;
            int felsohatar = rendezettTomb.Length - 1;
            int kozep = 0;
            do {
                kozep = (alsohatar + felsohatar) / 2;
                if (rendezettTomb[kozep] < 111) alsohatar = kozep + 1;
                if (rendezettTomb[kozep] > 111) felsohatar = kozep - 1;
            } while (alsohatar <= felsohatar && rendezettTomb[kozep] != 111);
            if (rendezettTomb[kozep] == 111)
                Console.WriteLine("Van, indexe: " + kozep);
            else Console.WriteLine("Nincs");

            Console.ReadKey();
        }
    }
}
