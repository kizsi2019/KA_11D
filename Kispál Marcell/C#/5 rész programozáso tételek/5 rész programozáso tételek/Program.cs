using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _5_rész_programozáso_tételek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[] Tömb = new int[] { 32, 12, 10, 9, 45, 90, 13, 8, 1, 42 };
            int összeg = 0;
            for (int i = 0; i < Tömb.Length; i++)
        }
        int++
        {
        össeg += [i]; 
        }
    Console.WriteLine);*/
            /* int[] randT = new int[10];
            Random r = new Random();
            for (int i = 0; i < randT.Lenght; i++)
             {
            randT[i] = Random.Next(0, 21);
            }
            int j = 0;
            while (j < randT.Lenght && randT[j] <= 15)
            {
            j++;
            }
            if (j < randT.Lenght) Console.WriteLine("Van");
            else Console.WriteLine("Nincs");
            */
            /* int[] randT = new int[10];
            Random r = new Random();
            for (int i = 0; i < randT.Lenght; i++)
            {
            randT[i] = r.Next(0, 21);
            }
            int db = 0;
            for (int i = 0; i < randT.Lenght; i++)
            {
            if (randT[i] % 2 ==0) db++;
            }
            else Console.WriteLine("A generált tömbben {0} db páros szám van, db");*/

            /*int[] Tömb = new int[] { 32, 12, 10, 9, 45, 90, 13, 8, 1, 42 };

                      int legnagyobb_index = 0;
                      int legkisebb_index = 0;
                      for (int i = 0; i < Tömb.Length; i++)
                      {

                          if (Tömb[i] > Tömb[legnagyobb_index]) legnagyobb_index = i;
                          if (Tömb[i] > Tömb[legkisebb_index]) legkisebb_index = i;
                      }
                      Console.WriteLine(
                          "A legnagyobb elem inexe {0}, értéke {1}", legnagyobb_index, Tömb[legnagyobb_index]);
                      Console.WriteLine(
                         "A legnagyobb elem inexe {0}, értéke {1}", legkisebb_index, Tömb[legkisebb_index]);*/

            //beolvasas
            /*StreamReader sr = new StreamReader("végeredmény.txt");
            List<string> eredmény = new List<string>();
            while (!sr.EndOfStream) {
                eredmény.Add(sr.ReadLine());

                    }
            sr.Close();
            //kiválasztás tétele
            Console.WriteLine("Adja meg a versenyző nevét: ");
            string név = Console.ReadLine();
            int i = 0;
            while (i < eredmény.Count && eredmény[i] != név)
            {
                i++;
            }
            Console.WriteLine("{0} nevű versenyző {1}. lett", név.Length is + 1);
            int[] beolvasas = new int[20];
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("adja meg a {0} számot: ", i + 1);
                beolvasas[i] = int.Parse(Console.ReadLine());
            }

            int j = 0;
            while (j < beolvasas.Length && beolvasas[j] % 3 != 0)
            {
                j++;
            }
            if (j < beolvasas.Length) Console.WriteLine("3mal osztható számot {0} -ra vitt be", j + 1);
            else Console.WriteLine("Nem adott meg 3-mal osztható számot!");



            Console.ReadKey();


                }
            }
         }


