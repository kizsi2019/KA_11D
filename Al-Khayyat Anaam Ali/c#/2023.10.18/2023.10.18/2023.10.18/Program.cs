using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023._10._18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  List<string> lista = new List<string>() { "banán", "alma", "körte", "narancs", "kiwi" };
              lista.Sort();
              foreach (string item in lista)
              {
                  Console.WriteLine(item);
              }
              Console.ReadKey();
            */
            List<int> lista = new List<int>() { 20, 31, 10 };
            int[] tömb = lista.ToArray();
            foreach (var item in tömb)
            {
            Console .WriteLine(item);
            }
        }


    }
}

        
