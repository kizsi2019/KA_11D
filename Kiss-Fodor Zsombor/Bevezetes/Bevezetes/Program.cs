using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bevezetes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int a = 7;
            int b = 3;
            int c = 4;
            int ab = a + b;
            b = b + 3;
            b += 3;
            b -= 2;
            

            Console.WriteLine(b);
            Console.WriteLine(ab);
            

            string szoveg = "kurva ";
            string szoveg2 = "anyád";
            string ossz = szoveg + szoveg2;
            
            int a = 12, b = 23, c= 34;
            int erednmeny = a + b + c;
            Console.WriteLine("Az eredmény " + erednmeny + " lett.");

            string naagyobb = a > b ? "a nagyobb, mint b" : "b nagyobb, mint a";
            Console.Write(naagyobb);

            int j, i = 2;
            j = i++;
            Console.WriteLine("j = " + j + "; i = " + i);
            int k, l = 2;
            k = ++l;
            Console.WriteLine("k = " + k + "; l = " + l);

            byte tulcsordulas = byte.MaxValue;
            tulcsordulas++;
            Console.WriteLine(tulcsordulas);
            */

            string beker = Console.ReadLine();
            int szam1 = int.Parse(beker);
            beker = Console.ReadLine();
            int szam2 = Convert.ToInt32(beker);
            int osszeg = szam1 + szam2;
            Console.WriteLine(osszeg);
            Console.ReadKey();

        }
    }
}
