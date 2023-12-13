using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faszom_ebbe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[] Tömb = new int[] { 32, 12, 10, 9, 45, 90, 13, 8, 1, 42 };

            int összeg = 0;
            for (int i = 0; i < Tömb.Length; i++)
            {
                összeg += Tömb[i];
            }
            Console.WriteLine("A tömbben tárolt szémok összege: {0}", összeg);






            int[] randT = new int[10];
            Random r = new Random();
            for (int i = 0; i < randT.Length; i++)
            {
                randT[i] = r.Next(0, 21);
            }
            int j = 0;
            while (j < randT.Length && randT[j] <= 15) 
            {
                j++;
            }
            if (j < randT.Length) Console.WriteLine("van");
            else Console.WriteLine("nincs bazdmeg");





            int[] randT = new int[10];
            Random r = new Random();
            for (int i = 0; i < randT.Length;)
            {
                randT[i] = r.Next(0, 21);
            }
            int db = 0;
            for (int i = 0; i < randT.Length; i++) 
            {
                if (randT[i] % 2 == 0) db++;
            }
            Console.WriteLine("A generált tömbben {0} db páros szám van", db);




            int[] Tömb = new int[] { 32, 12, 10, 9, 45, 90, 13, 8, 1, 42 };
            int legnagyobb_index = 0;
            int legkissebb_index = 0;
            for (int i = 0; i < Tömb.Length; i++)
            {
                if (Tömb[i] < Tömb[legnagyobb_index]) legnagyobb_index = i;
                if (Tömb[i] > Tömb[legkissebb_index]) legkissebb_index = i;
            }
            Console.WriteLine("A legnagyobb elem indexe {0}, értékre {1}", legnagyobb_index, Tömb[legnagyobb_index]);
            Console.WriteLine("A legkisseb elem indexe {0}, értékre {1}", legkissebb_index, Tömb[legkissebb_index]);





            StreamReader sr = new StreamReader("július.txt");
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
            Console.WriteLine("a legalacsonabb {0} án {1} fok", legalacsonyabb_i + 1, hőmérséklet[legalacsonyabb_i]);





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
            while (i < eredmény.Count && eredmény[i] != név)
            {
                i++;
            }
            Console.WriteLine("{0} nevű versenyző {1}. lett", név, i + 1);




            int[] beolvasás = new int[20];
            for(int i = 0;i < 20; i++)
            {
                Console.Write("Adja meg a {0}. számot: ", i + 1);
                beolvasás[i] = int.Parse(Console.ReadLine());

            }
            int j = 0;
            while (j < beolvasás.Length && beolvasás[j] % 3 != 0) 
            {
                j++;
            }
            if (j < beolvasás.Length) Console.WriteLine("3-mal osztható számot {0}.-ra vitt be!", j + 1);
            else Console.WriteLine("Nem adott meg 3-mal osztható számot");*/


            s
              
            Console.ReadKey();
        }
    }
}
