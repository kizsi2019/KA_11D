using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alakok
{
    internal class Program
    {
        static void Main(string[] args)
        { var liszt = new List<int>();
            /* liszt.Add(1);
             liszt.Add(5);
             liszt.Add(4);
             liszt.Add(8);
             foreach (var item in liszt)
             Console.WriteLine(liszt); 
            {
                var i = 37;
                for ( i = 37; i < 9999; i++)
                {
                    Console.Beep(i, 2);
                    
                }
            int x = 22;
            double y = (double)x;
            Console.WriteLine(y);

            Console.ReadLine();


            byte b = 11;
            Console.WriteLine(b);
            int egesz = b;
            Console.WriteLine(egesz);
            Console.ReadLine();
            
            b
            
            
            Console.WriteLine("Agya meg a Négyzet oldatlát");
            var zeg = Convert.ToInt32(Console.ReadLine()) ;
            
            var Ter = zeg * zeg;
            var Ker = zeg * 4;
            Console.WriteLine("A negyzet Kerülete " + Ker);
            Console.WriteLine("A negyzet Területe " + Ter);




            Console.ReadLine();


            */
            Console.WriteLine("Agya meg a Kör Sugarát");
            var zeg = Convert.ToInt32(Console.ReadLine());

            var Terület = zeg*zeg*3.14;
            var Kerület = zeg * 2 * 3.14;
            Console.WriteLine("A kör Területe " + Terület);
            Console.WriteLine("A kör Kerülete " + Kerület);

            Console.ReadLine();







        }
    }
}

