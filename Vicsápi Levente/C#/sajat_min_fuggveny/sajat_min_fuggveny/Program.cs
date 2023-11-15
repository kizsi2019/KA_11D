using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace sajat_min_fuggveny
{
    internal class Program
    {
        /*
        public T FindMin<T>(T[] arr)
        {
            T min = arr[0];
            foreach (T item in arr) 
            {
                if (Comparer<T>.Default.Compare(min, item) > 0)
                {
                    min = item;
                }
            }

            return min;
        }
        */

        public void Kiir<T>(T[] arr)
        {
            foreach (T item in arr)
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            Program findmin = new Program();
            Program Kiir = new Program();
            int[] tomb = new int[] { 4, 6, 3, 9, 7 };

            //Console.WriteLine(findmin.FindMin(tomb));
            Kiir.Kiir(tomb);

            Console.ReadKey();
        }
    }
}
