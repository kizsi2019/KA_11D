using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_3
{
    internal class Program
    {
        class Class
        {
            public delegate void Meghívás(int i);
            static public void Ciklus(Meghívás mh)
            {
                for (int i = 0; i < 1000; i++)
                {
                    mh(i);
                }
            }
        }
        class Program
        {
            static void Kiír(int i)
            {
                Console.WriteLine("i = {0}", i);
            }
            static void Main(string[] args)
            {
                Class.Meghívás mhKiír = new Class.Meghívás(Kiír);
                Class.Ciklus(mhKiír);
                Console.ReadKey();
            }
        }
    }
}
