using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tömb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] randomoltszamok_Matrix = new int[3,3];

            for (int i = 0; i < randomoltszamok_Matrix.Length; i++)
            {
                for (int j = 0; j < randomoltszamok_Matrix.Length; j++)
                {
                    Console.WriteLine("Adj meg egy számot!");
                    randomoltszamok_Matrix[i,j] = Convert.ToInt32(Console.ReadLine());
            }
                foreach (int item in randomoltszamok_Matrix)
                {
                    Console.WriteLine(item);
                }
                int osszeg = 0;
                foreach (int item in randomoltszamok_Matrix) ;
               

