using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace gyakorlas5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            var gyumolcsok = new string[]
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


            /*
            var tomb2d = new int[,]
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            Console.WriteLine("Bejárás for ciklusokkal");
            //A length tulajdonság itt nem használható
            //mivel a tömb 2d kiterjedésű. 
            for (int i = 0; i < tomb2d.GetLength(0); i++)
            {
                for (int j = 0; j < tomb2d.GetLength(1); j++)
                {
                    Console.Write("{0} ", tomb2d[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Bejárás foreach ciklusokkal");
            foreach (var elem in tomb2d)
            {
                Console.Write("{0} ", elem);
            }
            Console.ReadLine();*/

            /*
             int[] randomoltszamok_Vektor = new int[10];
             Random r = new Random();
             for (int i = 0; i < randomoltszamok_Vektor.Length; i++)
             {
                 randomoltszamok_Vektor[i] = r.Next(0, 100);
             } foreach (int item in randomoltszamok_Vektor)
             {
                 Console.WriteLine(item);
             }


             Array.Sort(randomoltszamok_Vektor);
             Console.WriteLine("Rendezve");
             foreach (int item in randomoltszamok_Vektor)
             {
                 Console.WriteLine(item);
             }
             Array.Reverse(randomoltszamok_Vektor);
             Console.WriteLine(" Forditva Rendezve");
             foreach (int item in randomoltszamok_Vektor)
             {
                 Console.WriteLine(item);
             }
            */

            int[] randomoltszamok_Vektor = new int[5];

            for (int i = 0; i < randomoltszamok_Vektor.Length; i++)
            {
                Console.WriteLine("Adj meg egy számot");
                randomoltszamok_Vektor[i] = Convert.ToInt32(Console.ReadLine());

            }
            foreach (int item in randomoltszamok_Vektor)
            {
                Console.WriteLine(item);
            }


            Array.Sort(randomoltszamok_Vektor);
            Console.WriteLine("Rendezve");
            foreach (int item in randomoltszamok_Vektor)
            {
                Console.WriteLine(item);
            }
            Array.Reverse(randomoltszamok_Vektor);
            Console.WriteLine(" Forditva Rendezve");
            foreach (int item in randomoltszamok_Vektor)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
