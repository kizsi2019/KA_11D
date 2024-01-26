using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nobel_Díj
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Awarded> awarded_people = new List<Awarded>();
            foreach (var i in File.ReadAllLines("orvosi_nobeldijak.txt").Skip(1))
            {
                awarded_people.Add(new Awarded(i));
            }
            Console.WriteLine($"The number of awarded people: {awarded_people.Count()}");
            Console.ReadKey();                                                                                                                                                                                                                                                              
        }
    }
}
