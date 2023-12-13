using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* namespace programozasitetelek
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] beolvasas = new int[20];
for (int i = 0; i < 20; i++)
{
    Console.Write("Adja meg a {0}. számot: ", i + i);

    4                beolvasas[i] = int.Parse(Console.ReadLine());
}
int j = 0;
while (j < beolvasas.Length && beolvasas[j] % 3 != 0)
{
    j++;
}
if (j < beolvasas.Length) Console.WriteLine("3mal osztható számot {0}.-ra vitte be!", j + 1);
else Console.WriteLine("Nem adott meg 3-mal osztható számot!");
        }
    }
}  */


namespace logarimikuskereses
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int[] rendezettTömb = new int[] { 10, 15, 18, 25, 31, 49, 60, 72, 80, 83 };

            int alsóhatár = 0;
            int felsőhatár = rendezettTömb.Length - 1;
            int közép = 0;
            do
            {
                közép = (alsóhatár + felsőhatár) / 2;
                if (rendezettTömb[közép] < 111) alsóhatár = közép + 1;
                if (rendezettTömb[közép] > 111) alsóhatár = közép - 1;
            } while (alsóhatár <= felsőhatár && rendezettTömb[közép] != 111);
            if (rendezettTömb[közép] == 111)
                Console.WriteLine("Van, indexe: " + közép);
            else Console.WriteLine("Nincs");

    }

    }
}






