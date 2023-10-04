using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace gyakorlas6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kerület számoló");
            Console.WriteLine("Add meg a 6 szög oldalát");
            try
            {
                var bevitel = Console.ReadLine();
                int szam = Convert.ToInt32(bevitel);

                if ((6 * szam) != 0)
                    Console.WriteLine($"A szöveg kerülete: {szam * 6}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message
                    );
            }
            Console.ReadKey();
        }
    }
}
