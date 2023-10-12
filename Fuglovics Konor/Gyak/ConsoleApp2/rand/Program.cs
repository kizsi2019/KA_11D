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

            /*int[] randumnumber_Vector = new int[5];
            Random r = new Random();
            for (int i = 0; i<randumnumber_Vector.Length; i++)
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
            }*/

            int[,] randumnumber_Matrix = new int[3,3];

            for (int i = 0; i<randumnumber_Matrix.GetLength(0); i++)
            {
                for (int j = 0; j<randumnumber_Matrix.GetLength(1); j++)
                {
                    Console.WriteLine("Adj meg egy számot!");
                    randumnumber_Matrix[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            foreach (int item in randumnumber_Matrix)
            {
                Console.WriteLine(item);
            }

            int total = 0;
            foreach (int item in randumnumber_Matrix)
            {
                total += item;
            }
            Console.WriteLine(" ");
            Console.WriteLine($"Összesen: {total}");

            int min = randumnumber_Matrix[0,0];
            foreach (int item in randumnumber_Matrix)
            {
                if (item < min)
                {
                    min = item;
                }
            }
            Console.WriteLine(" ");
            Console.WriteLine($"Minimum: {min}");
            int max = randumnumber_Matrix[0,0];
            foreach (int item in randumnumber_Matrix)
            {
                if (item > max)
                {
                    max = item;
                }
            }
            Console.WriteLine(" ");
            Console.WriteLine($"Maximum: {max}");
            int counter = 0;
            foreach (int item in randumnumber_Matrix)
            {
                if (item == 0)
                {
                    counter++;
                }
            }
            Console.WriteLine(" ");
            Console.WriteLine($"Számok (db): {counter}");
            Console.ReadKey();
        }
    }
}
