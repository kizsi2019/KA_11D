using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>() { 1, 2, 3, 4};
            bejaras pelda = new bejaras(lista);

            Console.ReadKey();
        }
    }
}
