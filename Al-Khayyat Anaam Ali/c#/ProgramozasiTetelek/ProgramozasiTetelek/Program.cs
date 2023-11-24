using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramozasiTetelek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] Tomb = new int[] { 32, 12, 10, 9, 45, 90, 13, 8, 1, 42 };
            //összegzés tétele:
            int osszeg = 0;
            for (int i = 0; i < Tomb.Length; i++)
            {
                osszeg += Tomb[i];
            }
            Console.WriteLine("A tömbben tárolt számok összege: {0}", osszeg);
            */

            /*
            int[] randT = new int[10];
            Random r = new Random(); // randomolás
            for (int i = 0; i < randT.Length; i++)
            {
                randT[i] = r.Next(0, 21);
            } // eldöntés tétele:
            int j = 0;
            while (j < randT.Length && randT[j] <= 15)
            {
                j++;
            }
            if (j < randT.Length) Console.WriteLine("Van");
            else Console.WriteLine("Nincs");
            */

            /*
            int[] randT = new int[10];
            Random r = new Random();
            // randomolás
            for (int i = 0; 1 < randT.Length; i++)
            {
                randT[i] = r.Next(0, 21);
            }
            // megszámlálás tétele:
            int db = 0;
            for (int i = 0; i < randT.Length; i++)
            {
                if (randT[i] % 2 == 0) db++;
            }
            Console.WriteLine("A generált tömbben {0}db páros szám van", db);
            */

            /*
            int[] Tomb = new int[] { 32, 12, 10, 9, 45, 90, 13, 8, 1, 42 };
            // Maximum/minimum kiválastás tétele
            int legnagyobb_index = 0;
            int legkisebb_index = 0;
            for (int i = 0; i < Tomb.Length; i++)
            {
                if (Tomb[i] > Tomb[legnagyobb_index]) legnagyobb_index = i;
                if (Tomb[i] < Tomb[legkisebb_index]) legkisebb_index = i;
            }
            Console.WriteLine("A legnagyobb elem indexe {0}, értéke {1}", legnagyobb_index, Tomb[legnagyobb_index]);
            Console.WriteLine("A legkisebb elem indexe {0}, értéke {1}", legkisebb_index, Tomb[legkisebb_index]);
            */

            /*
            // Beolvasás:
            StreamReader sr = new StreamReader("julius.txt");
            List<double> homerseklet = new List<double>();
            while (!sr.EndOfStream)
            {
                homerseklet.Add(double.Parse(sr.ReadLine()));
            }
            // Minimum kiválastás
            int legalacsonyabb_i = 0;
            for (int i = 0; i < homerseklet.Count; i++)
            {
                if (homerseklet[i] < homerseklet[legalacsonyabb_i]) legalacsonyabb_i = i;
            }
            Console.WriteLine("A legalacsonyabb hőmérséklet {0}.-án {1} fok volt!", legalacsonyabb_i + 1, homerseklet[legalacsonyabb_i]);
            */

            /*
            StreamReader sr = new StreamReader("vegeredmeny.txt");
            List<string> eredmény = new List<string>();
            while(!sr.EndOfStream) { 
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
            */
            /*
            int[] beolvasás = new int[20];
            for (int i = 0; i < 20; i++)
            { 
            Console.Write("Adja meg a {0}. számot: ", i + 1);
            beolvasás[i] = int.Parse(Console.ReadLine());
            }
            int j = 0;
            while (j < beolvasás.Length && beolvasás[j] % 3 != 0)
            {
                j++;
            }
            if (j < beolvasás.Length) Console.WriteLine("3mal osztható számot {0}.-ra vitt be!", j + 1);
            else Console.WriteLine("Nem adott meg 3-mal osztható számot!");
            */
            int[] beolvasás = new int[20];
            for (int i = 0; < 20; i++)
            {
                Console.WriteLine("Adja meg a {0}. számot", i + 1)

            }
            Console.ReadKey(); 
        }
    }
}
