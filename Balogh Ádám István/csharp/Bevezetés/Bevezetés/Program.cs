using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bevezetés
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Helló világ");
            Console.Write("Ez");
            Console.Write("mi?");*/
            //int a = 7;
            //int b = 3;
            //int ab = a + b;
            //b = b + 3;
            //b += 3;
            //b -= 2;
            //Console.WriteLine(b);
            //Console.WriteLine(ab);
            //string str1 = "alma";
            /*string str2 = "fa";
            string ossz = str1 + str2;
            Console.WriteLine("Az eredmény " + ossz + " lett");

            int a = 12, b = 23, c = 34;
            int eredmeny = a + b + c;*/
            //Console.WriteLine("Az eredmény " + eredmeny + " lett");

            /*int j, i = 2;
            j = i++;
            Console.WriteLine("j = " + j + "; i = " + i);
            int k, l = 2;
            k = ++l;
            Console.WriteLine("k = " + k + "; l = " + l);>*/
            //byte tulcsordulas = byte.MaxValue;
            //tulcsordulas++;
            //Console.WriteLine(tulcsordulas);
            string beker = Console.ReadLine(); // cigany vagy kys
            int szam1 = int.Parse(beker);
            int szam2 = Convert.ToInt32(beker);
            int összeg = szam1 + szam2;
            Console.WriteLine(összeg);
            Console.ReadKey();
        }
    }
}
