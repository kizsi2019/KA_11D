using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objektum_hozzáadás_listához
{
    public class objektum
    {
        List<objektum> konyvek = new List<objektum>();

        private string Szerzo { get; set; }
        private string Cim { get; set; }

        private int Oldal_szam {  get; set; }

        public void Addbook(string szerzo, string cim, int oldal_szam)
        {
            objektum konyv = new objektum
            {
                Szerzo = szerzo,
                Cim = cim,
                Oldal_szam = oldal_szam
            };
            konyvek.Add(konyv);
        }

        public void write_book_list()
        {
            foreach (var konyv in konyvek) 
            {
                Console.WriteLine("szerző: " + konyv.Szerzo + ", " + "cím: " + konyv.Cim + ", " + "oldalszám: " + konyv.Oldal_szam);
            }
        }
    }
}
