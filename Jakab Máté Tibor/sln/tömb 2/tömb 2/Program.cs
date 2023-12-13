using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace tömb_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] randomoltszamok_Matrix = new int[5];

            for (int i = 0; i < randomoltszamok_Matrix.Length;i++)
            {

                Console.WriteLine("Add meg a mátrix egy elemét!");
                randomoltszamok_Matrix[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (int item in randomoltszamok_Matrix)
            {
                Console.WriteLine(item);
            }
            int összeg = 0;
            foreach (int item in randomoltszamok_Matrix)
            {
                összeg += item;
            }
            int min = randomoltszamok_Matrix[0,0];
            foreach (int item in randomoltszamok_Matrix);
            {
                if (item > max)
                {
                    max = item;
                }
            }
        }
    }
}
