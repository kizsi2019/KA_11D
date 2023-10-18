using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parameter_transfering
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> oldlist = new List<int>() { 35, 23, 8};
            List<int> newlist = oldlist;
            newlist.Add(40);
            Console.Write("Contents of the old list: ");
            foreach (int item in oldlist)
            {
                Console.Write($"{item}, ");
            }
            Console.Write("\nContents of the new list: ");
            foreach (int item in newlist)
            {
                Console.Write($"{item}, ");
            }

            Console.ReadKey();
        }
    }
}
