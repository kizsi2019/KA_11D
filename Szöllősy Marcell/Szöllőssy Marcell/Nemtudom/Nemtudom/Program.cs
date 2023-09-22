using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nemtudom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //Console.WriteLine("Helló Cyka");
            //Console.Write("Ez");
            //Console.Write("mi?"); */
            //int a = 7;
            //int b = 3;
            //int ab = a + b
            //b = b + 3
            //b += 3;
            //b -= 2;
            //Console.WriteLine(a);
            //Console.WriteLine(ab);
            string str1 = "alma";
            string str2 = "fa";
            string ossz = str1 + str2;
            Console.WriteLine(ossz);
            //int a = 12, b = 23, c = 34;
            //int eredmeny = a + b + c;
            //Console.WriteLine("Az eredmeny" + eredmeny + " lett!");
            //int a = 1;
            //int b = 2;

            //string nagyobb = a > b;
            //int j, i = 2;
            //j = i++;
            //Console.Write("j = " + j + "; i = " + i)
            //int k, l = 2;
            //k = l++;
            //Console.WriteLine("k = " + k + "; l = " + l);
            /*byte tulcsordulas = byte.MaxValue;
            tulcsordulas++;
            Console.Writeline(tulcsordulas);*/
            string beker = Console.ReadLine();
            int szam1 = int.Parse(beker);
            int szam2 = Convert.toint32(beker);
            int osszeg = szam1 + szam2;
            Console.WriteLine(osszeg);
            Console.ReadKey();
        }
    }
}
