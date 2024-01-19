using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace programozási_tételek2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            StreamReader sr = new StreamReader("végeredmény.txt");
            List<string> eredmény = new List<string>();

            while(!sr.EndOfStream) 
            {
                eredmény.Add(sr.ReadLine());
            }
            sr.Close();

            Console.Write("Adja meg a versenyző nevét: ");
            string név = Console.ReadLine();

            int i = 0;

            while(i < eredmény.Count && eredmény[i] != név) 
            {
                i++;
            }
            Console.WriteLine("{0} nevű versenyző {1}. lett", név, i + 1);
            */

            int[] beolvasás = new int[20];

            for (int i = 0; i < 20; i++) 
            {
                Console.Write("Adja meg a {0}. számot ", i + 1);
                beolvasás[i] = int.Parse(Console.ReadLine());
            }

            int j = 0;
            while (j < beolvasás.Length && beolvasás[j] % 3 != 0) 
            {
                j++;
            }
            if (j < beolvasás.Length) Console.WriteLine("3mal osztható számot {0}.-ra vitt be", j + 1);
            else Console.WriteLine("Nem adott meg 3-mal osztható számot!");

            Console.ReadKey();
        }
    }
}
