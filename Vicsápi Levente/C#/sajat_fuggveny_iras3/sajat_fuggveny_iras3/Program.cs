using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sajat_fuggveny_iras3
{
    internal class Program
    {
        public void paros_szamok(int[] tomb)
        {
            int hany_paros = 0;
            foreach (int item in tomb) 
            {
                if (item % 2 == 0) 
                { 
                    hany_paros++;
                }
            }

            Console.WriteLine("Ebben a tömbben {0} darab páros szám van", hany_paros);
        }

        public void paratlan_szamok(int[] tomb) 
        {
            int hany_paratlan = 0;
            foreach (int item in tomb)
            {
                if (item % 2 == 1)
                {
                    hany_paratlan++;
                }
            }

            Console.WriteLine("Ebben a tömbben {0} darab páratlan szám van", hany_paratlan);
        }
        static void Main(string[] args)
        {
            Program progi = new Program(); 

            int[] számok = new int[] {1, 4, 6, 7, 9, 2, 5};

            progi.paros_szamok(számok);
            progi.paratlan_szamok(számok);

            Console.ReadKey();
        }
    }
}
