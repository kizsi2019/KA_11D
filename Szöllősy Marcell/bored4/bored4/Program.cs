using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bored4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] randomoltszamok_Matrix = new int[3, 3];

            for (int i = 0; i < randomoltszamok_Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < randomoltszamok_Matrix.GetLength(1); j++)
                {
                    Console.WriteLine("Add meg a vektor egy emelét!");
                    randomoltszamok_Matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }

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

            int min = randomoltszamok_Matrix[0, 0];
            foreach (int item in randomoltszamok_Matrix)
            {
                if (item < min)
                {
                    min = item;
                }
            }
            int max = randomoltszamok_Matrix[0, 0];
            foreach (int item in randomoltszamok_Matrix)
            {
                if (item > max)
                {
                    max = item;
                }
            }
            int szamlalo = 0;
            foreach (int item in randomoltszamok_Matrix) ;
            {
                if (item)
            }

    }
}
