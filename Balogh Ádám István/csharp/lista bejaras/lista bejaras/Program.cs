using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_bejaras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>() { 1, 2, 3, 4, 5};
            Bejaras bejaras = new Bejaras(lista);

            bejaras.Kiiras();

            Console.ReadKey();
            
        }
    }
}
