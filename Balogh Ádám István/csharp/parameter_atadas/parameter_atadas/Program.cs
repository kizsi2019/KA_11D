using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parameter_atadas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> régilista = new List<int>() {20, 31, 10};
            List<int> újlista = régilista;
            újlista.Add(40);

            Console.Write("rágilista tartalma: ");
            foreach (int item in régilista)
            {
                Console.Write(item + ", ");
            }

            Console.Write("\nújlista tartalam: ");
            foreach(int item in újlista)
            {
                Console.Write(item + ", ");
            }


        }
    }
}
