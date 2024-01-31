using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_oop
{
    public class Book
    {
        public string Szerzo { get; private set; }
        public string Cim { get; private set; }
        public int Kiadas_eve { get; private set; }

        List<Book> books = new List<Book>();

        public void Addbook(string cim, string szerzo, int kiadas_eve)
        {
            Book newBook = new Book
            {
                Szerzo = szerzo,
                Cim = cim,
                Kiadas_eve = kiadas_eve
            };

            books.Add(newBook);
        }
        
        
        public void Listbooks()
        {
            foreach (var book in books)
            {
                Console.WriteLine($"Cím: {book.Cim}, Szerző: {book.Szerzo}, Kiadás éve: {book.Kiadas_eve}");
            }
        }

        public void RemoveBook(string cimToRemove)
        {
            // Az eltávolítás a cím alapján
            var bookToRemove = books.FirstOrDefault(book => book.Cim.Trim().Equals(cimToRemove.Trim(), StringComparison.OrdinalIgnoreCase));

            if (bookToRemove != null)
            {
                books.Remove(bookToRemove);
                Console.WriteLine($"A könyv '{cimToRemove}' eltávolítva.");
            }
            else
            {
                Console.WriteLine($"A könyv '{cimToRemove}' nem található a könyvtárban.");
            }
        }

    }
}
