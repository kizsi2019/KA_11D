using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*console writeline("kopkip");
            Console.Write("Ez");
            Console.Write("pz")
            int a = 7;
            int b = 3;
            int ab = a + b;
            //b = b + 3;
            b += 3;
            b -= 2;
            Console.WriteLine(b);
            Console.WriteLine(ab);
            string str1 = "alma";
            string str2 = "fa";
            string ossz = str1 + str2;
            Console.WriteLine(" az eredmeny " + ossz + " lett");

            int a = 12, b = 23, c = 34;
            int eredmeny = a + b + c;
            Console.WriteLine("az eredmeny" + eredmeny + " lett");
            int a = 1;
            int b = 2;
            //a valtozatos a "b nagyobb mint a "szöveg kerül, mivel a feltétel nem igay
            string nagyobb = a > b ? "a nagyobb mint b";

            int j, i = 2;
            j = i++; // prefix
            Console.WriteLine("j = " + j + "; i = " + i);
            int k, l = 2;
            k = ++l; // prefix
            Console.WriteLine("k = " + k + "; l = " + l);
            byte tulcsordulas = byte.MaxValue;
            tulcsordulas++;
            Console.WriteLine(tulcsordulas);*/
            string beker = Console.ReadLine(); // szöveg bekérése
            int szam1 = int.Parse(beker);
            string beker = Console.ReadLine(); // szöveg bekérése
            int szam2 = Convert.ToInt32(beker);
            int összeg = szam1 + szam2;
            Console.WriteLine(összeg);

            Console.ReadKey();
        }
    }
}
