using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace olvasás
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "text.txt";

            try
            {
                string[] lines = File.ReadAllLines(path);

                foreach (string line in lines) 
                {
                    Console.WriteLine(line);
                }
            }

            catch (Exception ex) 
            {
                Console.WriteLine("Hiba történt: " + ex.Message);
            }

            Console.ReadKey();
        }
    }
}
