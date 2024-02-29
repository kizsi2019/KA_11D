using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyakorlás2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int ma = 21;
            int tegnap = 18;
            var szoveg = string.Format("Ma {0} fok volt, tegnap pedig {1}", ma, tegnap);

            Console.WriteLine(szoveg);

            Console.WriteLine("Így is lehet: {0}, {1}", ma, tegnap);
            Console.ReadKey();*/

            /*/double d = 1500.42;

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
            Console.WriteLine("{0:pozitív;negatív;nulla}", 0);
            Console.ReadKey();*/

            /*/int valtozo = 13;
            string interpolalt = $"{nameof(valtozo)} értéke: {valtozo}";*/

            using System;
            using System.Globalization;

namespace PeldaLokalizalas
    {
        class Program
        {
            static void Main(string[] args)
            {
                var uiCulture = CultureInfo.CurrentUICulture;
                var currentCulture = CultureInfo.CurrentCulture;
                var angolCulture = CultureInfo.CreateSpecificCulture("en-US");

                double d = 1.2579;

                Console.WriteLine("uiCulture: {0}", uiCulture.Name);
                Console.WriteLine("currentCulture: {0}", currentCulture.Name);

                var current = string.Format(currentCulture, "{0}, {1}, {2:C}", d, DateTime.Now, 32580);
                var angol = string.Format(angolCulture, "{0}, {1}, {2:C}", d, DateTime.Now, 32580);
                Console.WriteLine(current);
                Console.WriteLine(angol);

                var angolFormat = Convert.ToDouble("3.14", angolCulture);
                Console.WriteLine(angolFormat);

                Console.ReadKey();

            }
        }
    }


}
    }
}
