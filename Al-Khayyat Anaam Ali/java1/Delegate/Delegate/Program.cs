using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate11
{
    internal class Program
    {
        delegate void VoiDelegate(); //a delegate létrehozása
        static void Metódus()
        {
            Console.WriteLine("A metódus lefutott!");
        }
        static void Main(string[] args)
        {
            VoiDelegate vd = new VoiDelegate(Metódus); // létrejön a hivatkozás
            vd();// meghívja a megadott metódust, amire hivatkozik
        }
    }
}
