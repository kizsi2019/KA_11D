using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Toto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2. feladat miben eltároljuk a txt fálj tartalmát
            List<Fogadasok> fogasaoklista = new List<Fogadasok>();
            foreach (var sor in File.ReadAllLines("toto.txt").Skip(1))
            {
                fogasaoklista.Add(new Fogadasok(sor));
                //Console.WriteLine(sor);
            }

            //3. feladat miben kiírjuk mennyi fordulónk van
            Console.WriteLine($"(3. Feladat) --- Összesen ennyi forduló volt eddig: {fogasaoklista.Count}");
            

            //4. feladat miben megszámoljuk összesen hány telitalálatos szelvények voltak
            int OsszesTelitalalat = 0;
            for (int i = 0; i < fogasaoklista.Count; i++)
            {
                OsszesTelitalalat += fogasaoklista[i].Telitalalat;
            }

            Console.WriteLine($"(4. Feladat) --- Összesen ennyi telitalálat volt: {OsszesTelitalalat}");

            //5. feladat



            //6. feladat




            //7. feladat



            //9. feladat



            //10. feladat


            Console.ReadKey();
        }
    }
}
