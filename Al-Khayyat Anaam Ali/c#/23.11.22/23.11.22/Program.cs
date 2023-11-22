using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._11._22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*    int[] randT = new int[10];
                Random r = new Random();
                for (int i = 0; i < randT.Length; i++)
                {
                    randT[i] = r.Next(0, 21);
                }
                int db = 0;
                for (int i = 0; i < randT.Length; i++)
                {
                    if (randT[i] % 2 == 0) db++;
                }
                Console.WriteLine("A generált tömbben {0} db páros szám van" db);
                Console.ReadKey(); 

            int[] Tömb = new int[] { 32, 12, 10, 9, 45, 90, 12, 8, 1, 42 };

            int legnagyobb_index = 0;
            int legkisebb_index = 0;
            for (int i = 0; i < Tömb.Length; i++)
            {
                if (Tömb[i] > Tömb[legnagyobb_index]) legnagyobb_index = i;
                if (Tömb[i] < Tömb[legkisebb_index]) legkisebb_index = i;
            }
            Console.WriteLine(
               "A legnagyobb elem indexe {0}, értéke {1}", legnagyobb_index, Tömb[legnagyobb_index]);
            Console.WriteLine(
               "A legkisebb elem indexe {0}, értéke {1}", legkisebb_index, Tömb[legkisebb_index]);
            Console.ReadKey();
            */

            StreamReader sr = new StreamReader("Július.txt");
            List<double> hőmérséklet = new List<double>();
            while (!sr.EndOfStream)
            {
                hőmérséklet.Add(double.Parse(sr.ReadLine()));
            }
            int legalacsonyabb_i = 0;
            for (int i = 0; i < hőmérséklet.Count; i++)
            {
                if (hőmérséklet[i] < hőmérséklet[legalacsonyabb_i]) legalacsonyabb_i = i;
            }
            Console.WriteLine("A legalacsonyabb hőmérséklet {0}.-án {1} fok volt!", legalacsonyabb_i + 1, hőmérséklet[legalacsonyabb_i]);
            Console.ReadKey();
        }
    }
}
