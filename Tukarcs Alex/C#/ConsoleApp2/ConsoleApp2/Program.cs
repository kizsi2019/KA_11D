using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
                Console.WriteLine("Van indexe: " + közép);
            else Console.WriteLine("Nincs")
        }
    }
}
