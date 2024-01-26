using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozat2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nev;
           
            Console.WriteLine("Kérem Adja Meg a nevét ");

            nev = Console.ReadLine();
            int bekért_bev = 0;
            List<int> bevétel = new List<int>();
            bool bev_lekérés = true;
            while (bev_lekérés)
         
            {  
                Console.WriteLine("Kéerem agya meg a bevételét (Adjon 1 alati számot a befejezéshez)");
                
                bekért_bev = Convert.ToInt32(Console.ReadLine());
                if (bekért_bev > 1) {
                    bevétel.Add(bekért_bev);

                } else
                {
                    bev_lekérés = false;
                }
            }
          
     
            bool ki_lekérés = true;
            List<int> kiadás = new List<int>();
            int bekért_kid;
            while (ki_lekérés) {
            
            Console.WriteLine("Kéerem agya meg a kiadását (Adjon 1 alati számot a befejezéshez)");
                bekért_kid = Convert.ToInt32(Console.ReadLine());
                if (bekért_kid > 1)
                {
                    kiadás.Add(bekért_kid);
                } else
                {
                    ki_lekérés = false;
                }
            }
            int ösz_kiadás = kiadás.Sum();
            int ösz_bevétel = bevétel.Sum();
            int egyenleg = ösz_bevétel - ösz_kiadás;
            Console.WriteLine(nev + " Egyenlege: " + egyenleg);
            int legkis_kid = kiadás.Min();
            int legnagy_kid = kiadás.Max();
            Console.WriteLine(nev + " Legnagyobb kiadása: " + legnagy_kid);
            Console.WriteLine(nev + " Legkissebb kiadása: " + legkis_kid);


            Console.ReadLine();


        }
    }
}
