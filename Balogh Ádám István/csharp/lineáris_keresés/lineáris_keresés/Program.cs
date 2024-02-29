using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lineáris_keresés
{
    internal class Program
    {
        public static int Lineariskereses(int[] tomb, int elem)
        {
            int index = -1;

            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] == elem)
                {
                    index = i; 
                    break;
                }
            }
            return index;
        }
        static void Main(string[] args)
        {
            var tomb = new int[] { 9, 6, 0, 0, 1, 2, 2, 2, 3, 1, 5, 4, 8, 2, 8, 6 };

            int poz = Lineariskereses(tomb, 2);

            Console.WriteLine($"A kettes indexe: {poz}");

            Console.ReadKey();
        }
    }
}
