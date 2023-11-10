using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prezentáció_minta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> lista1 = new List<int>();

            lista1.Add(1);
            lista1.Add(2);
            lista1.Add(3);

            /*
            foreach (int i in lista1)
            {
                Console.Write("{0} ", i);
            }
            */


            //Console.WriteLine(lista1.Count);



            lista1.Remove(2);



            foreach (int i in lista1)
            {
                Console.Write("{0} ", i);
            }


            lista1.Clear();

            Console.ReadKey();
        }
    }
}
