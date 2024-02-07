using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_class_függvények
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>() { 1, 2, 3, 4, 5};

            Func<int, int> kiirasdelegatum = Kiiras;

            Bejaras(lista, kiirasdelegatum);

            Console.ReadKey();
        }

        public static int Kiiras(int elem)
        {
            return elem;
        }
        public static void Bejaras(List<int> lista, Func<int, int> fv)
        {
            foreach (int i in lista) 
            {
                Console.Write(Kiiras(i) + " ");
            }
        }
    }
}
