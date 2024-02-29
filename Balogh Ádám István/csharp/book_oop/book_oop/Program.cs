using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book library = new Book();

            library.Addbook("A kis herceg", "Antoine de Saint-Exupéry", 1943);
            library.Addbook("A kis cigány", "Levi", 2024);

            library.Listbooks();
            
            Console.ReadKey();
        }
    }
}
