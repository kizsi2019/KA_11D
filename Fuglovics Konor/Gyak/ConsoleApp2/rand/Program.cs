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
            /*int[] randumnumber_Vector = new int[10];
            Random r = new Random();
            for (int i = 0; i<randumnumber_Vector.GetLength(0); i++)
            {
                 randumnumber_Vector[i] = r.Next(0,1000);
            }
            foreach (int item in randumnumber_Vector)
            {
                Console.WriteLine(item);
            }
            Array.Sort(randumnumber_Vector);
            Console.WriteLine("Rendezve:");
            foreach (int item in randumnumber_Vector)
            {
                Console.WriteLine(item);
            }
            Array.Reverse(randumnumber_Vector);
            Console.WriteLine("Fordítva: ");
            foreach (int item in randumnumber_Vector)
            {
                Console.WriteLine(item);
            }
            Array.IndexOf(randumnumber_Vector, 1);
            Console.WriteLine("Fordítva: ");
            foreach (int item in randumnumber_Vector)
            {
                Console.WriteLine(item);
            }*/

            int[] randumnumber_Vector = new int[3];
            Random r = new Random();
            for (int i = 0; i<randumnumber_Vector.GetLength(0); i++)
            {
                Console.WriteLine("Adj meg egy számot!");
                randumnumber_Vector[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (int item in randumnumber_Vector)
            {
                Console.WriteLine(item);
            }
            Array.Sort(randumnumber_Vector);
            Console.WriteLine("Rendezve:");
            foreach (int item in randumnumber_Vector)
            {
                Console.WriteLine(item);
            }
            Array.Reverse(randumnumber_Vector);
            Console.WriteLine("Fordítva: ");
            foreach (int item in randumnumber_Vector)
            {
                Console.WriteLine(item);
            }
            Array.IndexOf(randumnumber_Vector, 3);
            Console.WriteLine("Fordítva: ");
            foreach (int item in randumnumber_Vector)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
