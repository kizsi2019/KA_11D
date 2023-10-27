using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tomb
{
    internal class Program
    {
        public enum Hetnapjai
        {
            Hetfo,
            Kedd,
            Szerda,
            Csutortok,
            Pentek,
            Szombat,
            Vasarnap
        }
        static void Main(string[] args)
        {
            /*
            var gyumolcsok = new string[]
            {
                "alma", "körte", "szilva"
            };

            var bevitelek = new string[3];

            for (int i = 0; i < bevitelek.Length; i++)
            {
                Console.WriteLine("{0}. bevitel: ", i);
                bevitelek[i] = Console.ReadLine();
            }

            foreach (var gyumolcs in gyumolcsok)
            {
                Console.WriteLine(gyumolcs);
            }
            foreach (var bevitel in bevitelek)
            {
                Console.WriteLine(bevitel);
            }
            */

            /*
            //tömb elemeinek meghatározása
            //minden sor külön zárójelet igényel
            var tomb2d = new int[,]
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            Console.WriteLine("Bejárás for ciklusokkal");
            //A length tulajdonság itt nem használható
            //mivel a tömb 2d kiterjedésű. 
            for (int i = 0; i < tomb2d.GetLength(0); i++)
            {
                for (int j = 0; j < tomb2d.GetLength(1); j++)
                {
                    Console.Write("{0} ", tomb2d[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Bejárás foreach ciklusokkal");
            foreach (var elem in tomb2d)
            {
                Console.Write("{0} ", elem);
            }
            */

            /*
            int[] randomoltszamok_Vektor = new int[10];
            Random r = new Random();
            for (int i = 0; i < randomoltszamok_Vektor.Length; i++)
            {
                randomoltszamok_Vektor[i] = r.Next(0, 100);
            }

            foreach(int item in randomoltszamok_Vektor)
            {
                Console.WriteLine(item);
            }
            */

            
            

            int[] mátrix = new int[5];
            
            for (int i = 0; i < mátrix.GetLength(0); i++)
            {
                Console.Write("Adj meg számokat! ");
                mátrix[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (int item in mátrix)
            {
                Console.WriteLine(item);
            }
            Array.Sort(mátrix);
            Console.WriteLine("Rendezve:");

            foreach (int item in mátrix )
            {
                Console.WriteLine(item);
            }


            Array.Reverse(mátrix);
            Console.WriteLine("Fordított: ");

            foreach (int item in mátrix)
            {
                Console.WriteLine(item);
            }


            Console.ReadKey();
        }
    }
}
