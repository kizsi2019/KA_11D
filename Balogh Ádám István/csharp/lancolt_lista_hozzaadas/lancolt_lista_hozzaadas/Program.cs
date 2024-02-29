using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lancolt_lista_hozzaadas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lista = new LinkedList<string>();

            lista.AddLast("egy");
            lista.AddLast("példa");
            lista.AddLast("program");
            lista.AddLast("lenne");

            lista.AddFirst("Ez");

            Console.WriteLine("Lánc elemek száma: {0}", lista.Count);
            Console.Write("Lánc tartalma előre: ");

            foreach (var item in lista)
            {
                Console.Write("{0} ", item);
            }

            Console.Write("\nLánc tartalma vissza: ");
            var vissza = lista.Last;

            while (vissza != null)
            {
                Console.Write("{0} ", vissza.Value);
                vissza = vissza.Previous;
            }

            Console.ReadKey();
        }
    }
}
