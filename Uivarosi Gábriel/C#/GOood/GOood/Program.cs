using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace GOood
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Class1 first = new Class1();
            Class2 second = new Class2();
            Class3 third = new Class3();

            Console.Write($"Adja meg az első nevet: ");
            first.SetName(Console.ReadLine());
            Console.Write($"Adja meg a {first.GetName()} korát");
            first.SetAge(Console.ReadLine());
            Console.Write($"Adja meg a {first.GetName()} telefonszámát: ");
            first.SetPhone(Console.ReadLine());
            Console.Write($"Adja meg az második nevet: ");
            second.SetName(Console.ReadLine());
            Console.Write($"Adja meg a {second.GetName()} korát");
            second.SetAge(Console.ReadLine());
            Console.Write($"Adja meg a {second.GetName()} telefonszámát: ");
            second.SetPhone(Console.ReadLine());
            Console.Write($"Adja meg az harmadik nevet: ");
            third.SetName(Console.ReadLine());
            Console.Write($"Adja meg a {third.GetName()} korát");
            third.SetAge(Console.ReadLine());
            Console.Write($"Adja meg a {third.GetName()} telefonszámát: ");
            third.SetPhone(Console.ReadLine());

            string response;
            Console.WriteLine("akarja fojtatni az ujabb adatok bekérését (Y/N)");
            response = Console.ReadLine().ToUpper();
       /*     do
            {
                // don't
                Console.Write($"Adja meg menyit menjen {first.GetName} előre: ");
                first.goig(Console.ReadLine());
                Console.Write($"Adja meg menyit menjen {second.GetName} előre: ");
                second.goig(Console.ReadLine());
                Console.Write($"Adja meg menyit menjen {second.GetName} előre: ");
                second.goig(Console.ReadLine());
            } while (response == "Y");
       */

        }
    }
}
