using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parameteratadas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> regilista = new List<int>() { 20, 31, 10 };
            List<int> ujlista = regilista;
            ujlista.Add(40);
            Console.WriteLine("Régilista tartalma: ");
            foreach (int item in regilista)
            {
                Console.WriteLine(item + ", ");
            }
            Console.WriteLine("\nÚjlista tartalma: ");
            foreach (int item in ujlista)
            {
                Console.WriteLine(item + ", ");
            }
            Console.ReadKey();
        }
    }
}
