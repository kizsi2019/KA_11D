using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace _2023._12._13_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Beolvasás
            Streamreader sr = new Streamreader("végeredmény.txt");
            List<string> eredmény = new List<string>();
            while (!sr.EndofStream) {
            eredmény.Add(sr.ReadLine());
            }
            sr.Close();
            //kiválasztás tétele
            Console.WriteLine("Adja meg a versenyző nevét ");
            string név = Console.ReadLine();
            int i = 0;
            while (i < eredmény.Count && eredmény[i] ! = név)
            {
                i++;
            }
            Console.WriteLine("{0} nevű versenyző {1} lett", név, i + 1);
            Console.ReadKey();
        }
    }
}
