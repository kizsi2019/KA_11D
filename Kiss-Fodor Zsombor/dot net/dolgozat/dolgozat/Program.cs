using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dolgozat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 feladat
            Console.WriteLine("kérem a diák nevét");
            string diaknev = Console.ReadLine();
            string valasz = "0";
            List<double> list = new List<double>();
            while (valasz != "") 
            {
                Console.WriteLine("adjon meg egy jegyet");
                valasz = Console.ReadLine();
                if (valasz != "")
                {
                    //wow ez rohadt jó! :D
                }
            }
            //2 feladat
            var szoveg = new Stack<char>();
            string adat = Console.ReadLine();
            Console.WriteLine(adat);
            /*
            //char adatchat = Convert.ToChar(adat);
            szoveg.Push(adatchat);
            foreach (char c in szoveg) 
            { 
                Console.WriteLine(c);
            }
            */
            Console.ReadLine();

            //pöcsön vágom magamat egy kocsi kulcsal
        }
    }
}
