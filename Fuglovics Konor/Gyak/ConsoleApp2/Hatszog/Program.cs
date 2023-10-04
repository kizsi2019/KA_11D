using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatszog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hatszög számláló V1.0");
            Console.WriteLine("Add meg a hatszögnek méreteit! (cm, a, b, c, d, e, f");
            try
            {
                var a = Console.ReadLine();
                int num = Convert.ToInt32(a);
                if (num != 0)
                {
                    var b = Console.ReadLine();
                    int num2 = Convert.ToInt32(b);
                    if (num2 != 0)
                    {
                        var c = Console.ReadLine();
                        int num3 = Convert.ToInt32(c);
                        if (num3 != 0)
                        {
                            var d = Console.ReadLine();
                            int num4 = Convert.ToInt32(d);
                            if (num4 != 0)
                            {
                                var e = Console.ReadLine();
                                int num5 = Convert.ToInt32(e);
                                if (num5 != 0)
                                {
                                    var f = Console.ReadLine();
                                    int num6 = Convert.ToInt32(f);
                                    if (num6 != 0)
                                    {
                                        int total = num + num2 + num3 + num4 + num5 + num6;
                                        int total2 = num * num2 * num3 * num4 * num5 * num6;
                                        Console.WriteLine("Kerület: {0}cm", total);
                                        Console.WriteLine("Terület: {0}cm²", total2);
                                    }
                                    else
                                    {
                                        Console.WriteLine("A 0 nem jó!");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("A 0 nem jó!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("A 0 nem jó!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("A 0 nem jó!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("A 0 nem jó!");
                    }
                }
                else
                {
                    Console.WriteLine("A 0 nem jó!");
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("Program Crash! {0}", error);
            }
            Console.ReadKey();
        }
    }
}
