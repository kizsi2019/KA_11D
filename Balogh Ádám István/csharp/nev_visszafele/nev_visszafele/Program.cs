using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nev_visszafele
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Add meg a neved ");
            string nev = Console.ReadLine();
            string nagybetus_nev = nev.ToUpper();


            Stack<char> betuk = new Stack<char>();

            foreach (char betu in nagybetus_nev) 
            { 
                betuk.Push(betu);
            }

            while (betuk.Count > 0)
            {
                var visszafele = betuk.Pop();
                Console.Write(visszafele);
            }

            Console.ReadKey();
        }
    }
}
