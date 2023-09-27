using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyakorlas2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int ma = 21;
            int tegnap = 18;

            var szoveg = string.Format("Ma {0} fok volt, tegnap pedig {1}", ma, tegnap);

            Console.WriteLine(szoveg);


            Console.WriteLine("Így is lehet: {0}, {1}", ma, tegnap);
            */

            /*
            Console.WriteLine("Pénz: {0:C1}", 3148); //forint
            Console.WriteLine("Százalék: {0:P3}", 0.123456); //százalék
            Console.WriteLine("Általános: {0:G}", 132354); //általános szám
            Console.WriteLine("Exponenciális: {0:E}", 132354); //hatványalak
            Console.WriteLine("Hexa: {0:X}", 255); //16-os számrendszer
            */

            /*
            int valtozo = 13;
            string interpolalt = $"{nameof(valtozo)} értéke: {valtozo}";
            
            Console.WriteLine(interpolalt);
            */

            /*
            string nev = "world";
            string hello = $"Hello {nev}";

            Console.WriteLine(hello);
            */

            
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
            

            /*
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
            */



            Console.ReadKey();
        }
    }
}
