using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sajat_fuggveny_gyak
{
    internal class Program
    {
        
        public void szamolas(int[] arr)
        {
            int osszeg = 0;
            foreach (int item in arr)
            {
                osszeg += item;
            }

            Console.WriteLine(osszeg);
        }
        static void Main(string[] args)
        {
            int[] szamok = new int[] {1, 2, 3};

            Program osszeg = new Program();

            osszeg.szamolas(szamok);

            Console.ReadKey();
            
        }
    }
}
