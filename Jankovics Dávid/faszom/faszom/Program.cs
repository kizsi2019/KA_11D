using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faszom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int be = Console.Read();
            string be2 = Console.ReadLine();

            Console.WriteLine();*/

            /*int x = 22;

            double y = (double)x;
            Console.WriteLine();

            Console.ReadKey();*/
            /*int x = 3;
            Console.WriteLine(x / 4);

            //0,75 mert az x átkonvertálódik double típusra
            Console.WriteLine((double)x / 4);

            Console.ReadKey();*/
            Console.WriteLine("Add meg a négyzet oldalát!");
            int a =Convert.ToInt32(Console.ReadLine());
            int kerulet = 4 * a;
            int terulet = a * a,
            Console.Write(terulet);
            Console.Write(kerulet);
        }
    }
}
