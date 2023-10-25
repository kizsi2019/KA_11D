using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace lista_gyak
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List <string> lista = new List<string>() { };
            


            string szo;
            do
            {
                Console.Write("Adj meg valamit ");
                szo = Console.ReadLine();
                lista.Add(szo);
            }

            while (szo != "");

            string[] tömb = lista.ToArray();

            Console.Write("A lista tartalma: ");

            foreach (string item in tömb)
            {
                if (tömb.Length > 0 && item != "")
                {
                    Console.Write(item + ", ");
                }
                
            }


            Console.ReadKey();
        }
    }
}
