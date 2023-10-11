using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rand
{
    class Program
    {
        static void Main(string [] args)
        {
            int[] randumnumber_Vector = new int[10];
            Random r = new Random();
            for (int i = 0; i<randumnumber_Vector.Length; i++)
            {
                randumnumber_Vector [i] = r.Next(0,1000);
            } foreach (int item in randumnumber_Vector)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
