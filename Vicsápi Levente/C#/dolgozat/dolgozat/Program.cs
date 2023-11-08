using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dolgozat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Add meg a neved ");
            string nev = Console.ReadLine();

            int szam;

            List<int> list = new List<int>();

            do
            {
                Console.WriteLine("Add meg a jegyeid ");
                szam = Convert.ToInt32(Console.ReadLine());
                
                if (szam >= 1)
                {
                    list.Add(szam);
                }
             
            }
            while(szam != 0);

            Console.WriteLine();

            foreach (int i in list)
            {
                
                Console.WriteLine(i);
            }

            int osszeg = 0;
            int darab = list.Count;

            Console.WriteLine();
           

            foreach (int i in list)
            {
                osszeg = osszeg += i;
            }

            

            int atlag = osszeg / darab;
            int legjobb = list.Max();
            int legrosszabb = list.Min();

            Console.WriteLine("{0} átlaga: {1}", nev, atlag);
            Console.WriteLine();
            Console.WriteLine("{0} legjobb jegye: {1}", nev, legjobb);
            Console.WriteLine();
            Console.WriteLine("{0} legroszabb jegye: {1}", nev, legrosszabb);
            


            Console.ReadKey();
        }
    }
}
