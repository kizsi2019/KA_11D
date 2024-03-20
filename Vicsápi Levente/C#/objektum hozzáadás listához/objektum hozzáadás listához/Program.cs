using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objektum_hozzáadás_listához
{
    internal class Program
    {
        static void Main(string[] args)
        {
            objektum obj = new objektum();

            obj.Addbook("Levi", "Tíz kicsi néger", 100);

            obj.Addbook("Levi", "Kalandom", 150);

            obj.write_book_list();

            Console.ReadKey();
        }
    }
}
