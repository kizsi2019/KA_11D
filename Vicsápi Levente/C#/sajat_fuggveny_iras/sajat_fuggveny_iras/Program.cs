using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sajat_fuggveny_iras
{
    internal class Program
    {
        public T FindMax<T>(T[] arr)
        {
            T max = arr[0];
            foreach (T item in arr)
            {
                if (Comparer<T>.Default.Compare(item, max) > 0)
                {
                    max = item;
                }
            }
            return max;
            
        }
        static void Main(string[] args)
        {
            Program progi = new Program();

            int[] szamok = { 10, 5, 7, 15, 3 };
            int maxSzam = progi.FindMax(szamok); 

            Console.WriteLine(maxSzam);

            Console.ReadKey();

        }
    }
}
