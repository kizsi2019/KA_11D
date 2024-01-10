using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feladat2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*StreamReader sr = new StreamReader("végeredmény.txt");
            List<string> eredmény = new List<string>();
            while (!sr.EndOfStream) {
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
            Console.WriteLine("{0} nevű versenyző {1}. lett", név, i + 1);*/
            /*int[] beolvasás = new int[20];
            for (int i = 0; i < 20; i++)
            {
                Console.Write("Adja meg a(z) {0}. számot: ", i + 1);
                beolvasás[i] = int.Parse(Console.ReadLine());
            }
            int j = 0;
            while (j < beolvasás.Length && beolvasás[j] % 3 != 0) 
            {
                j++;
            }
            if (j < beolvasás.Length) Console.WriteLine("3-mal osztható számot {0}.-ra vitt be!", j + 1);
            else Console.WriteLine("Nem adott meg 3-mal osztható számot!");*/
            int[] rendezettTömb = new int[] { 10, 15, 18, 25, 31, 49, 60, 72, 80, 90 };
            int alsóhatár = 0;
            int felsőhatár = rendezettTömb.Length - 1;
            int közép = 0;
            do
            {
                közép = (alsóhatár + felsőhatár) / 2;
                if (rendezettTömb[közép] < 111) alsóhatár = közép + 1;
                if (rendezettTömb[közép] > 111) felsőhatár = közép - 1;
            } while (alsóhatár <= felsőhatár && rendezettTömb[közép] != 111);
            if (rendezettTömb[közép] == 111)
                Console.WriteLine("Van, indexe: " + közép);
            else Console.WriteLine("Nincs.");
            Console.ReadKey();
        }
    }
}
