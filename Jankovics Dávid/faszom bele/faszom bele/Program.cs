using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faszom_bele
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int ma = 21;
            int tegnap = 18;
            int szoveg = string.Format('Ma {0} fok volt, tegnap pedig {1}', ma, tegnap);

            Console.WriteLine(szoveg);
            Console.WriteLine('Így is lehet: {0} {1}')

            Console.WriteLine("Pénz: {0:C1}", 3148);
            Console.WriteLine("Százalék: {0:P3}", 0.123456);
            Console.WriteLine("Általános: {0:G}", 132354);
            Console.WriteLine("Exponenciális: {0:E}", 132354);
            Console.WriteLine("Hexa: {0:X}", 255);
            Console.ReadKey();

            double d = 1500.42;

            //1500,4200
            Console.WriteLine("{0:00.0000}", d);
            //(1500),42
            Console.WriteLine("{0:(#).##}", d);
            //1500,4
            Console.WriteLine("{0:0.0}", d);
            //1 500
            Console.WriteLine("{0:0,0}", d);
            //150042%
            Console.WriteLine("{0:0%}", d);
            //[Foo  ]
            Console.WriteLine("[{0,-5}]", "Foo");
            //[  Foo]
            Console.WriteLine("[{0,5}]", "Foo");

            //pozitív
            Console.WriteLine("{0:pozitív;negatív;nulla}", 4);
            //negatív
            Console.WriteLine("{0:pozitív;negatív;nulla}", -4);
            //nulla
            Console.WriteLine("{0:pozitív;negatív;nulla}", 0);*/

            //int valtozo = 13;
            //string interpolalt = $"{nameof(valtozo)} értéke: {valtozo}";
            //Console.ReadKey();

            var ido = DateTime.Now;

            Console.WriteLine("{0:d}", ido);
            Console.WriteLine("{0:D}", ido);
            Console.WriteLine("{0:t}", ido);
            Console.WriteLine("{0:T}", ido);
            Console.WriteLine("{0:f}", ido);
            Console.WriteLine("{0:F}", ido);
            Console.WriteLine("{0:g}", ido);
            Console.WriteLine("{0:G}", ido);
            Console.WriteLine("{0:M}", ido);
            Console.WriteLine("{0:r}", ido);
            Console.WriteLine("{0:Y}", ido);
            Console.WriteLine("{0:yyyy-mm-dd, dddd tt hh:mm:ss}", ido);
            Console.ReadKey();
        }
    }
}
