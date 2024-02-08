using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Totó
{
    class Program
    {
        static void Main(string[] args)
        {
            List<NumList> statistic = new List<NumList>();
            foreach (var i in File.ReadAllLines("toto.txt").Skip(1))
            {
                statistic.Add(new NumList(i));
            }

            Console.WriteLine($"Total rounds: {statistic.Count()}");


            Console.WriteLine($"{hit}");
            Console.ReadKey();
        }
    }
}
