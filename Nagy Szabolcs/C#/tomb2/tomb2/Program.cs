using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tomb2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] lista = new int[2, 2];

            for (int i = 0; i < lista.GetLength(0); i++)
                {
                    for (int j = 0; j < lista.GetLength(1); j++)
                    {
                        Console.Write("Adj meg számokat! ");
                        lista[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
            }

            /*
            foreach (int i in lista)
            {
                Console.WriteLine(i);

            }
            */

            /*
            int osszeg = 0;
            foreach (int i in lista) osszeg = osszeg + i;

            Console.WriteLine();
            Console.WriteLine("Az összeg: " + osszeg);
            Console.ReadKey();
            */

            /*
            int legkisebb = lista[0, 0];
            int legnagyobb = lista[0, 0];

            foreach (int item in lista)
            {
                if (item < legkisebb)
                {
                    legkisebb = item;
                }

                if (item > legnagyobb)
                {
                    legnagyobb = item;
                }
            }

            Console.WriteLine();
            Console.WriteLine("A legnagyobb szám: " + legnagyobb);
            Console.WriteLine("A legkisebb szám: " + legkisebb);
            */

            int szamlalo = 0;
            foreach (int item in lista)
            {
                if (item == 0)
                {
                    szamlalo++;
                }
                
            }

            Console.WriteLine();
            Console.WriteLine(szamlalo);
            Console.ReadKey();

        }
    }
}
