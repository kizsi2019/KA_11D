using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osszegzes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
            int[] tomb = new int[] { 32, 12, 10, 9, 45, 90, 13, 8, 1, 42 };
            int osszeg = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                osszeg += tomb[i];
            }
            Console.WriteLine("anyád: {0}", osszeg);

            int[] randT = new int[10];
            Random fucker = new Random();
            for (int i = 0;i < randT.Length; i++)
            {
                randT[i] = fucker.Next(0, 21);
            }
            int j = 0;
            while (j < randT.Length && randT[j] <= 15) 
            {
                j++;
            }
            if (j < randT.Length) 
            {
                Console.WriteLine("ANYÁD");
            } 
            else 
            {
                Console.WriteLine("KURVA");
            }

            int[] randT = new int[10];
            Random fucker = new Random();
            for (int i = 0; i < randT.Length; i++)
            {
                randT[i] = fucker.Next(0, 21);
            }

            int db = 0;
            for (int i = 0;i < randT.Length; i++)
            {
                if (randT[i] % 2 == 0) db++;
            }
            Console.WriteLine("anyád: {0}", db);
            

            int[] tomb = new int[] { 32, 12, 10, 9, 45, 90, 13, 8, 1, 42 };
            int min = 0;
            int max = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] < tomb[min]) min = i;
                if (tomb[i] > tomb[max]) max = i;
            }
            Console.WriteLine("anyád: {0}", tomb[max]);
            Console.WriteLine("anyád: {0}", tomb[min]);
            */

            StreamReader sr = new StreamReader("július.txt");
            List<Double> homerseklet = new List<Double>();
            while (!sr.EndOfStream)
            {
                
                homerseklet.Add(double.Parse(sr.ReadLine()));
            }
            int leghidegebb = 0;
            for (int i = 0; i < homerseklet.Count; i++)
            {
                if (homerseklet[i] < homerseklet[leghidegebb]) leghidegebb = i;
            }
            Console.WriteLine("leghidegebb idő {0}", leghidegebb);

            Console.ReadLine();
        }
}
}