using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozat
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] egyenleg = new int[31]; 
            List<int> forint = new List<int>();
            Random rng = new Random();
            for (int i = 0; i<egyenleg.Count(); i++)
            {
                egyenleg[i] = rng.Next(1, 1000);
                forint.Add(egyenleg[i]);
            }
            Console.Write(egyenleg);

            Console.ReadKey();
        }
    }
}
