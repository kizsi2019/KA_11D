using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace másolás
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] randomoltszamok_Vektor = new int[10];
            Random r = new Random();
            //for ciklussal írni és olvasni is tudunk
            randomoltszámok_Vektor[0] = r.Next(0, 100);
        } foreach (int item in randomoltszamok_Vektor) {
            //csak olvasásra jó
            Console.Writeline(item);

        }
    Console.Readkey
    }
}
