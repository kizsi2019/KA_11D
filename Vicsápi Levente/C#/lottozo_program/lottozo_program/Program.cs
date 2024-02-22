using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lottozo_program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random veletlen = new Random();

            HashSet<int> szamok = new HashSet<int>();
            List<int> lottoszamok = new List<int>();
            HashSet<int> talalt_szamok = new HashSet<int>();
            

            while (szamok.Count < 5)
            {
                int veletlen_szam = veletlen.Next(1, 91);
                szamok.Add(veletlen_szam);
            }
           
            foreach (int i in szamok)
            {
                lottoszamok.Add(i);
            }

            foreach(int i in lottoszamok)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

            int talalt = 0;
            

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Adj meg egy számot(1-90)! ");
                int szam_adat = Convert.ToInt32(Console.ReadLine());
                

                foreach (int j in lottoszamok)
                {
                    if (szam_adat == j)
                    {
                        talalt++;
                    }
                }
            }
                
            
            Console.WriteLine();
            Console.WriteLine($"Ennyi számot találtál el: {talalt}");
            Console.ReadKey();
        }
    }
}
