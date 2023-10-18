using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*var gyumolcsok = new string[]
            {
                "alma", "körte", "szilva"
            };

            var bevitelek = new string[3];

            for (int i = 0; i < bevitelek.Length; i++)
            {
                Console.WriteLine("{0}. bevitel: ", i);
                bevitelek[i] = Console.ReadLine();
            }

            foreach (var gyumolcs in gyumolcsok)
            {
                Console.WriteLine(gyumolcs);
            }
            foreach (var bevitel in bevitelek)
            {
                Console.WriteLine(bevitel);
            }

            Console.ReadLine();*/

            /*enum Hetnapjai : byte
        {
            Hetfo = 1,
            Kedd,
            Szerda,
            Csutortok,
            Pentek,
            Szombat,
            Vasarnap
        }


        static void Main(string[] args)
        {
            string[] tesztek = { "1", "7", "0", "99", "Hetfo", "Szerda", "Pentek", "pentek", "Hiba" };
            foreach (var teszt in tesztek)
            {
                try
                {
                    Hetnapjai nap = (Hetnapjai)Enum.Parse(typeof(Hetnapjai), teszt);
                    Console.WriteLine(nap);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("Hiba: " + ex.Message);
                }
                Hetnapjai nap2 = Hetnapjai.Hetfo; //alap érték
                Enum.TryParse(teszt, out nap2); //generikus tryparse hívás
                Console.WriteLine(nap2);
            }
            Console.ReadKey();*/
            /*int[,] randomoltszamok_Matrix = new int[3,3];
            Random r = new Random();
            for (int i = 0; i < randomoltszamok_Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < randomoltszamok_Matrix.GetLength(1); j++)
                    randomoltszamok_Matrix [i,j] = r.Next(0, 100);
            } foreach (int item in randomoltszamok_Matrix)
            {
                Console.WriteLine(item);
            }
            Array.Sort( randomoltszamok_Matrix);
            Console.ReadKey();*/
            int[] randomoltszamok_Matrix = new int[3];
            Random r = new Random();
            for (int i = 0; i < randomoltszamok_Matrix.GetLength(0); i++)
            {
                
                    randomoltszamok_Matrix[i] = r.Next(0, 100);
            }
            foreach (int item in randomoltszamok_Matrix)
            {
                Console.WriteLine(item);
            }
            Array.Sort(randomoltszamok_Matrix);
            Console.ReadKey();
        }
    }
}
