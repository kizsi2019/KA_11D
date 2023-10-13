using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyakorlas8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,] randomoltszamok_Matrix = new int[3, 3];

            for (int i = 0; i < randomoltszamok_Matrix.GetLength(0); i++)

                for (int j = 0; j < randomoltszamok_Matrix.GetLength(1); j++)
                {
                Console.WriteLine("Add meg a vektor egy elemét!");
                randomoltszamok_Matrix[i, j] = Convert.ToInt32(Console.ReadLine());

            }
            foreach (int item in randomoltszamok_Matrix)
            {
                Console.WriteLine(item);
            }

            int osszeg = 0;
            foreach (int item in randomoltszamok_Matrix)
            {
                osszeg += item;
            }

            int min = randomoltszamok_Matrix[0, 0];
            foreach (int item in randomoltszamok_Matrix)
            {
                if (item < min)
                {
                    min = item;

                }
            }

    }
}
