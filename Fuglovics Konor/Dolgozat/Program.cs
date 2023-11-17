using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> egyenleg = new List<int> { };
            Random forint = new Random();
            int rn = forint.Next(2500, 1000000);
            Console.WriteLine("Add meg a neved!");
            string a = Console.ReadLine();
            if (a == "")
            {
                Console.WriteLine("Név hiányzik!");
            }
            else
            {
                Console.WriteLine("Add meg a legnagyobb kiadásod!");
                var b = Console.ReadLine();
                int num = Convert.ToInt32(b);
                if (num == 0)
                {
                    Console.WriteLine("A kiadás nem lehet 0!");
                }
                else
                {
                    egyenleg.Add(num);
                    Console.WriteLine("Add meg a legkisebb kiadásod");
                    var c = Console.ReadLine();
                    int num2 = Convert.ToInt32(c);
                    if (num2 == 0)
                    {
                        Console.WriteLine("A kiadás nem lehet 0!");
                    }
                    else
                    {
                        egyenleg.Add(num2);
                        Console.WriteLine($"{a.ToUpper()} egyenlege: {num + num2 - rn}");
                        Console.WriteLine($"{a.ToUpper()} legnagyobb kiadása: {num}");
                        Console.WriteLine($"{a.ToUpper()} legkisebb kiadása: {num2}");
                    }
                }
            }

            Console.ReadKey();

            Console.ReadKey();
        }
    }
}
