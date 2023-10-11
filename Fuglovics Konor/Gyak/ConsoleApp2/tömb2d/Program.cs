using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tömb2d
{
    class Program
    {
        static void Main(string [] args)
        {
            var tömb2d = new int [,]
            {
                {1, 2, 3 },
                {4, 5, 6 },
                {7, 8, 9 }
            };

            Console.WriteLine("Bejárás for ciklusnál");

            for (int i=0; i<tömb2d.GetLength(0); i++)
            {
                for (int j=0; j<tömb2d.GetLength(1); j++)
                {
                    Console.Write("{0} ",tömb2d [i,j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Bejárás foreach ciklusokkal");
            foreach (var elem in tömb2d)
            {
                Console.Write("{0} ",elem);
            }
            Console.ReadKey();
        }
    }
}
