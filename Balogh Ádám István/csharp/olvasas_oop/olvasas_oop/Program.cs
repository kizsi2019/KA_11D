using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace olvasas_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Ember> adatok = new List<Ember>();
            

            foreach (var adat in File.ReadAllLines("Ember.txt")) 
            {
                adatok.Add(new Ember(adat));
            }

            
            
            Console.ReadKey();
        }
    }
}
