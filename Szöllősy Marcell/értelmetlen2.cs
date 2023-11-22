using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace értelmetlen2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[] Tömb = new int[] { 32, 12, 10, 9, 45, 90, 13, 8, 1, 42 };
            int összeg = 0;
            for (int i = 0; i < Tömb.Length; i++)
            {
                i++;
            }
            if (int < Tömb.Length) Console.WriteLine("van");
            else Console.WriteLine("Nincs");*/

            /*int[] randT = new int[10];
            Random r = new Random(); 
            for (int i = 0; i < randT.Length; i++)
            {
                randT[i] = r.Next(0, 21);
            }
            int j = 0;
            while (j < randT.Length && randT[j] <= 5) 
            {
                j++;
            }
            if (j < randT.Length) Console.WriteLine("Van");
            else Console.WriteLine("Nincs");*/

            /*int[] randT = new int[10];
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
            Console.WriteLine("A generált tömbben {0}db páros szám van", db);

            Console.WriteLine()*/

            /*int[] Tömb = new int[] { 32, 12, 10, 9, 45, 90, 13, 8, 1, 42 };
            int legnagyobb_index = 0;
            int legkisebb_index = 0;
            for (int i = 0; i < Tömb.Length; i++)
            {
                if (Tömb[i] > Tömb[legnagyobb_index]) legnagyobb_index = i;
                if (Tömb[i] < Tömb[legkisebb_index]) legkisebb_index = i;
            }
            Console.WriteLine(" A legnagyobb elem indexe {0}, értéke {1}", legnagyobb_index, Tömb[legnagyobb_index]);
            Console.WriteLine(" A legkisebb elem indexe {0}, értéke {1}", legkisebb_index, Tömb[legkisebb_index]);*/

            /*StreamReader sr = new StreamReader("Július.txt");
            List<double> hőmérséklet = new List<double>();
            while (!sr.EndOfStream)
            {
                hőmérséklet.Add(double.Parse(sr.ReadLine()));
            }
            int legalacsonabb_i = 0;
            for (int i = 0; i < hőmérséklet.Count; i++)
            {
                if (hőmérséklet[i] < hőmérséklet[legalacsonabb_i]) legalacsonabb_i = i;
            }
            Console.WriteLine("A legalacsonyabb hőmérséklet {0}.-án {1} fo volt", legalacsonabb_i + 1, hőmérséklet[legalacsonabb_i]);*/

            StreamReader sr = new StreamReader("végeredmény.txt");
            List<string> eredmény = new List<string>();
            while (!sr.EndOfStream)
            {
                eredmény.Add(sr.ReadLine());
            }
            sr.Close();
            Console.Write("Adja meg a versenyző nevét: ");
            string név = Console.ReadLine();
            int i = 0;
            while ( i< eredmény.Count && eredmény[i] != név ) 
            {
                i++;
            }
            Console.WriteLine("{0}")
        }
    }
}
