using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bináris_keresés
{
    internal class Program
    {
        public static int BinarisKeres(int[] tomb, int keresettertek)
        {
            int eleje = 0;
            int vege = tomb.Length;
            while (eleje <= vege)
            {
                int i = (eleje + vege) / 2;
                if (tomb[i] == keresettertek) return i;
                else if (tomb[i] < keresettertek)
                {
                    eleje = i + 1;
                }
                else if (tomb[i] > keresettertek)
                {
                    vege = i - 1;
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            var tomb = new int[] { 0, 0, 1, 2, 2, 2, 3, 1, 4, 5, 6, 8, 9 };
            int index = BinarisKeres(tomb, 8);
            

            //int index = Array.BinarySearch(tomb, 8);
            Console.WriteLine("A nyolcas indexe: {0}", index);
            

            Console.ReadKey();
        }
    }
}
