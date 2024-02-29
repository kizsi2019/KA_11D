using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;

namespace Toto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> Beolvasot_értékek = new List<string>();

            foreach (var item in File.ReadAllLines("toto.txt")) 
                {
       
                Beolvasot_értékek.Add(item);
            }
            // ex string 2020;16;2;0;0;1111XX11X12X1X
            Console.WriteLine("3-es Feladat:" + Beolvasot_értékek.Count() + " " + "forduló adatai találhatók a forrásállományban! ");
         
            string sor = Beolvasot_értékek[1];
            string[] osztás = sor.Split(';');
            string rész = osztás[5];
      /*      foreach (var item in Beolvasot_értékek)
                sor = item;
            osztás = sor.Split(';');
            rész = osztás[3];
            int előző = 0;
            if (Convert.to == előző)
           {
      
         }
             
                
*/

            Console.ReadLine();


        }
    }
}
