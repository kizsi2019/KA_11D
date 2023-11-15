using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sajat_fuggveny_gyak2
{
    internal class Program
    {
        public void Kivonas(int[] arr)
        {
            int kulonbseg = arr[0] * 2;
            foreach (int item in arr) 
            {
                kulonbseg -= item;
            }

            Console.WriteLine(kulonbseg);
        }
        static void Main(string[] args)
        {
            int[] szamok = new int[] {10, 5, 2};

            Program progi = new Program();

            progi.Kivonas(szamok);

            Console.ReadKey();
        }
    }
}
