using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cserés_rendezés
{
    internal class Program
    {
        public static int[] CseresRendezes(int[] bemenet)
        {
            int[] tomb = new int[bemenet.Length];
            Array.Copy(bemenet, tomb, bemenet.Length);

            for (int i = 0; i < tomb.Length; i++)
            {
                for (int j = 0; j < tomb.Length; j++)
                {
                    if (tomb[i] < tomb[j])
                    {
                        var tmp = tomb[i];
                        tomb[i] = tomb[j];
                        tomb[j] = tmp;
                    }
                    
                }
            }
            return tomb;
        }
        static void Main(string[] args)
        {
            var tomb = new int[] { 9, 6, 0, 0, 1, 2, 2, 2, 3, 1, 5, 4, 8, 2, 8, 6 };

            foreach (int i in tomb)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

            var csere = CseresRendezes(tomb);
            foreach (int i in csere) 
            {
                Console.Write(i + " ");
            }

            Console.ReadKey();
        }
    }
}
