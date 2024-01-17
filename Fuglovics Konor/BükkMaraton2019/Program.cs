using System;
using System.Collections.Generic;
<<<<<<< HEAD
=======
using System.IO;
>>>>>>> 0758e27e55a72f5ac8be1e4e1e816bf86f6b12b5
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BükkMaraton2019
{
    internal class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD

=======
            //3.
            List<Versenyzo> versenyzok = new List<Versenyzo>();
            foreach (var sor in File.ReadAllLines("bukkm2019.txt").Skip(1))
            {
                versenyzok.Add(new Versenyzo(sor));
            }
            Console.WriteLine($"Versenytávot nem teljesítők: {(1 - versenyzok.Count / 691.0) * 100}%");
            Console.ReadKey();
>>>>>>> 0758e27e55a72f5ac8be1e4e1e816bf86f6b12b5
        }
    }
}
