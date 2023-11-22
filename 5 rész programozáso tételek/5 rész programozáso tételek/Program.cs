using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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

  int[] Tömb = new int[] { 32, 12, 10, 9, 45, 90, 13, 8, 1, 42 };

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
               "A legnagyobb elem inexe {0}, értéke {1}", legkisebb_index, Tömb[legkisebb_index]);


        }


