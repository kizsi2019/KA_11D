using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    internal class Program
    {
        
             delegate void VoidDelegate(); //a delegate lértehozása
            static void Method()
            {
                Console.WriteLine("A metódus lefutott!");
            }
            static void Main(string[] args)
            {
                VoidDelegate vd = new VoidDelegate(Method); //létrejön a hivatkozás
                vd(); //meghívja a megadott emtódust, amire hivatkozik
                Console.ReadKey();
            }
        
    }
}
