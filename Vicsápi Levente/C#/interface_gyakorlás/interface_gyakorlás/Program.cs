using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace interface_gyakorlás
{
    interface IKöszönés
    {
        void Reggel();
        void Este();
        void Napközben();
    }

    interface IÜdvözlés
    {
        void Szia(string név);
    }

    class Köszönés_Üdvözlés : IKöszönés, IÜdvözlés
    {
        public void Reggel() { Console.WriteLine("Jó reggelt!"); }
        public void Este() { Console.WriteLine("Jó estét!"); }
        public void Napközben() { Console.WriteLine("Jó napot!"); }

        public void Szia(string név) { Console.WriteLine($"Szia {név}!"); }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Köszönés_Üdvözlés hi = new Köszönés_Üdvözlés();

            hi.Reggel();
            Console.WriteLine();
            hi.Este();
            Console.WriteLine();
            hi.Napközben();
            Console.WriteLine();
            hi.Szia("Levi");

            Console.ReadKey();
        }
    }
}
