using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace szecska
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  StreamReader sr = new StreamReader("végeredméy.txt");
              List<string> eredmeny = new List<string>();
              while (sr.EndOfStream) {
                  eredmeny.Add(sr.ReadLine());
              }
              sr.Close();



            Console.Write("Adja meg a versenyző evét: ");
              string nev = Console.ReadLine();
          int i = 0;
          while (i < eredmeny.Count && eredmeny[i] != nev)
              {
                  i++;
              }
      Console.WriteLine("(0) nevű versenyző {1} lett", nev, i + 1);  
              Console.ReadKey();*/

           /* int[] beolvasás = new int[20];
            for (int i = 0; i < 20; i++)
            {
                Console.Write("Adja meg a {0}, számot: ", 1 + i);
                beolvasás[i] = int.Parse(Console.ReadLine());
            }
            int j = 0;
            while (j < beolvasás.Length) && beolvasás[j] % 3 != 0)
                    {
                j++;
            }
            if (j < beolvasás.Length) Console.WriteLine("3mal osztható számot {0}-ra vitt be", j + 1);
            else Console.WriteLine("Nem adott meg 3-mal osztható számot'")
                    Console.ReadKey();*/
           int[] rendezettTömb = new int[2] { 10, 15, 18, 25, 31, 49, 60, 72, 88, 83};
            int alsóhatár = 0;
            int felsőhatár = rendezettTömb.Length - 1;
            int közép = 0;
            do
            {
                közép = (alsóhatár + felsőhatár) / 2;
                if (rendezettTömb) [közép] < 111 alsóhatár = közép + 1;
                if (rendezettTömb) [közép] < 111 felsőhatár = közép - 1;
            } while (alsóhatár <= felsőhatár && rendezettTömb[közép] != 111);
            if (rendezettTömb[közép] == 111)
                Console.WriteLine("Van, indexe" + közép);
            else Console.WriteLine("nincs");
            Console.ReadKey();

        }

        }
    }

