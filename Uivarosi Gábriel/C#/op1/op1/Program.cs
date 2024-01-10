using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace op1
{
    internal class Program
    {   
        
        static void Main(string[] args)
        {
            Ember e = new Ember("Józsi", 22, 6666);
            Console.WriteLine(e.Név);
            Console.WriteLine(e.Életkor);
            Console.WriteLine(e.Irányitószám);
            Console.ReadKey();
            Ember f = new Ember("Pista", -23, 6653);
            Console.WriteLine(f.Név);
            Console.WriteLine(f.Életkor);
            Console.WriteLine(f.Irányitószám);
            Console.ReadKey();
            
        }
    }
}
