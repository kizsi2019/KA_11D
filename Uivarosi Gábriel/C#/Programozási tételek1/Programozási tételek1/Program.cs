using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programozási_tételek1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*     int[] Tömb = new int[] { 32, 12, 10, 9, 45, 90, 13, 8, 1, 42 };
     int összeg = 0;
     foreach (int item in Tömb)
     {
         összeg += item;
     }
     // jobb
  //   int összeg = Tömb.Sum();
     Console.WriteLine("A tömbben tárolt számok összege: {0}", összeg);

int[] radT = new int[10];
Random r = new Random();
for (int i = 0; i < radT.Length; i++)
{
    radT[i] = r.Next(0, 21);
}
int j = 0;
while (j < radT.Length && radT[j] <= 15) {
j++;
}
if (j < radT.Length)
{
    Console.WriteLine("van");

}
else Console.WriteLine("Nincs");     
int[] radT = new int[10];
Random r = new Random();
for (int i = 0; i < radT.Length; i++)
{
    radT[i] = r.Next(0, 21);
}
int db = 0;
for (int i = 0;i < radT.Length; i++)
{
    if (radT[i] % 2 == 0) db++;
}
Console.WriteLine("A generált tömbben {0}db páros szám van", db);


int[] Tömb = new int[] { 32, 12, 10, 9, 45, 90, 13, 8, 1, 42 };

int legnagyobb_index = 0;
int legkisebb_index = 0;
for (int i = 0; i < Tömb.Length; i++)
{
    if (Tömb[i] > Tömb[legnagyobb_index]) legnagyobb_index = i;
    if (Tömb[i] < Tömb[legkisebb_index]) legkisebb_index = i;
}
Console.WriteLine("A legnagyobb elem indexe {0}, értéke {1}", legnagyobb_index, Tömb[legnagyobb_index]);
Console.WriteLine("A legkisebb elem indexe {0}, értéke {1}", legkisebb_index, Tömb[legkisebb_index]);
*/

            StreamReader sr = new StreamReader("július.txt");
            List<double> hőmérséklet = new List<double>();
            while (sr.EndOfStream)
            {
                hőmérséklet.Add(double.Parse(sr.ReadLine()));

            }
            int legalacsoabb_i = 0;
            for (int i = 0; i < hőmérséklet.Count; i++)
            {
                if (hőmérséklet[i] < hőmérséklet[legalacsoabb_i]) legalacsoabb_i = i;

            }

            Console.WriteLine("A Legalacsonyabb Hőmérséklet {0}.-án {1} fok volt!", legalacsoabb_i + 1, hőmérséklet[legalacsoabb_i]);

            Console.ReadKey();
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=9vCb_ZopT4A");
            Console.ReadLine();


        }
    }
}
