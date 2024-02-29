using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nevezetes2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("vegerendmeny.txt");
            List<string> list = new List<string>();
            while (!sr.EndOfStream)
            {
                list.Add(sr.ReadLine());
            }
            sr.Close();
            Console.WriteLine("among us");
        }
    }
}
