using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szorzas_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Szorzas matek = new Szorzas(6, 5);

            Console.WriteLine(matek.Eredmeny);

            Console.ReadKey();
        }
    }
}
