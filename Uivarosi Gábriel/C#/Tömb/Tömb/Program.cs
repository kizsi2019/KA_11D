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
            
            int öszzeg = 0;
            var Vektor =new Int32[2,2];
            for (int i = 0; i < Vektor.GetLength(0); i++)
            {
                for (int j = 0; j < Vektor.GetLength(1); j++)
                {
                    Console.WriteLine("Agy számot!!");
                    Vektor[i,j] = Convert.ToInt32(Console.ReadLine());

                }
            }
            foreach (int i in Vektor) Console.WriteLine(i);
            foreach (int i in Vektor) öszzeg += i;
            Console.ReadLine();
            Console.WriteLine("Az öszeg:"+ öszzeg);
            Console.ReadLine();
            int min = Vektor[0,0];
            int max = Vektor[0,0];
            foreach (int i in Vektor) { 
                if (i > max)
                {
                    max = i;
                }
                if (i < min)
                {
                    min = i;
                }
            }
            Console.WriteLine("Minimum:" + min);
            Console.WriteLine("Maximum:" + max);
            Console.ReadLine();
        }
    }
}
