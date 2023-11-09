using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace November_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> grades = new List<int>;
            int count = 0;
            Console.WriteLine("Add meg a neved!");
            string a = Console.ReadLine();
            if (a == "")
            {
                Console.WriteLine("Név hiányzik!");
            }
            else
            {
                Console.WriteLine("Add meg a legjobb jegyed!");
                var b = Console.ReadLine();
                int num = Convert.ToInt32(b);
                if (num == 0 || num >= 6)
                {
                    Console.WriteLine("Nem létezö jegyet adott meg!");
                }
                else
                {
                    count =+ 1;
                    Console.WriteLine("Add meg a legrosszab jegyed!");
                    var c = Console.ReadLine();
                    int num2 = Convert.ToInt32(c);
                    if (num2 == 0 || num2 >= 6)
                    {
                        Console.WriteLine("Nem létezö jegyet adott meg!");
                    }
                    else
                    {
                        List.Add (num2)
                        count =+ 1;
                        double d = 
                        var rnd = Math.FLoor(d);
                        Console.WriteLine($"{a} átlaga: {rnd}");
                        Console.WriteLine($"{a} legjobb jegye: {num}");
                        Console.WriteLine($"{a} legrosszabb jegye: {num2}");
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
