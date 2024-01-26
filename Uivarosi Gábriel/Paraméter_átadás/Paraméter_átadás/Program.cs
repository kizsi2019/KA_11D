using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paraméter_átadás
{
    internal class Program
    {
        static void Main(string[] args)
        {
         List<int> Régilista = new List<int>() { 20, 31, 10};
            List<int> újralista = Régilista;
            újralista.Add(40);
            Console.WriteLine("Régilista Tartalma");
              foreach (int i in Régilista) Console.WriteLine(i);
            Console.WriteLine("Újgilista Tartalma");
            foreach (int i in újralista) Console.WriteLine(i);


            Console.ReadKey();
            Random random = new Random();
            while (true)
            {
                int h = random.Next(1, 59);
                int w = random.Next(1, 59);
                Console.SetWindowSize(w, h);
            }
        }
    }
}
