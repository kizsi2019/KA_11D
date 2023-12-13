using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programozási_Tételek_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                       StreamReader sr = new StreamReader("végeredmény.txt");
                       List<string> eredmény = new List<string>();
                       while (!sr.EndOfStream)
                       {
                           eredmény.Add(sr.ReadLine());
                       }
                       sr.Close();

                       Console.WriteLine("Adja meg a versenyző nevét: ");
                       string név = Console.ReadLine();
                       int i = 0;
                       while (i < eredmény.Count && eredmény[i] != név) {
                           i++;
                               }
              //         if (i  <= 9) { 
                       Console.WriteLine("{0} nevű versenyző {1}. lett", név, i + 1);
                //       } else
               //        {
              //             Console.WriteLine("nincs ijen nevű versenyző");
              //         }

                       */
            /* 
             // Ismétlés
            int[] beolvasás = new int[20];
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Adja meg a {0}. számot", i+1);
                beolvasás[i] = int.Parse(Console.ReadLine());

            }
            int j = 0;
            while (j < beolvasás.Length && beolvasás[j] % 3 != 0) 
            { j++;  }
            if (j < beolvasás.Length) Console.WriteLine("3mal osztható száamot {0}. -ra vitt be!", j + 1);
            else Console.WriteLine("Nem adott meg 3-mal osztható számot!");

            */
            int[] rendezettTömb = new int[] {10 , 15, 18, 25, 31, 49, 60, 72, 80};
            int alsóhatár = 0;
            int felsőhatár = rendezettTömb.Length - 1;
            int  közép = 0;
            do {
                közép = (alsóhatár + felsőhatár) / 2;
                if (rendezettTömb[közép] < 111) alsóhatár = közép
            }





            Console.ReadLine();






        }
    }
}
