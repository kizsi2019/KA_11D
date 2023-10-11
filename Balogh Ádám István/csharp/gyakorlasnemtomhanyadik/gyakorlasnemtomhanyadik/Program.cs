using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyakorlasnemtomhanyadik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] randomoltszamok_Vektor = new int[10];
            Random r = new Random();
            for (int i = 0; i < randomoltszamok_Vektor.Length; i++)
            {
                randomoltszamok_Vektor[i] = r.Next(0, 100);
            }   foreach (int item in randomoltszamok_Vektor)
            {

                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
