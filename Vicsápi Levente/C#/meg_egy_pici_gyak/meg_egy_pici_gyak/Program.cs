using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meg_egy_pici_gyak
{
    internal class Program
    {
        public void Valami<T>(IEnumerable<T> lista) 
        { 
            foreach (T item in lista) 
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            Program progi = new Program();

            List<string> lista = new List<string>() {"nigör", "csumi"};
            List<int> lista2 = new List<int>() {1, 2, 3, 4 ,5};

            int[] tömb = new int[] {1, 2,3, 4, 5};
            string[] tömb2 = new string[] {"nigör", "csumi" };

            progi.Valami(lista);
            Console.WriteLine();
            progi.Valami(lista2);
            Console.WriteLine();
            progi.Valami(tömb);
            Console.WriteLine();
            progi.Valami(tömb2);

            Console.ReadKey();
        }
    }
}
