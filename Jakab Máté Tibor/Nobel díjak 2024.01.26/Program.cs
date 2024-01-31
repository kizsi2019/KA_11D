using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace nobeldij
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2. Feladat
            List<Díjazott> díjazottak = new List<Díjazott>();

            

            foreach (var i in File.ReadAllLines("orvosi_nobeldijak.txt").Skip(1)) 
            {
              díjazottak.Add(new Díjazott(i));
            }

            Console.WriteLine(díjazottak.Count);

            Console.ReadKey();
        }

        
        
    }
}
