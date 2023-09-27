namespace ConsoleApp1
{
    internal class Program
    {
        static bool Teszt1()
        {
            Console.WriteLine("Teszt1 kiértékelése...");
            return false;
        }

        static bool Teszt2()
        {
            Console.WriteLine("Teszt2 kiértékelése...");
            return true;
        }

        static void Main(string[] args)
        {
            /*int a = Math.Abs(-3);
            Console.WriteLine(a);
            double b = Math.Ceiling(1.23);
            Console.WriteLine(b);
            double c = Math.Floor(1.23);
            Console.WriteLine(c);
            double d = Math.Round(1.563333, 2);
            Console.WriteLine(d);
            Console.WriteLine(Math.PI);
            Console.WriteLine(Math.E);;

            var sugar = 12;
            Console.WriteLine(" kör kerület és terület számító");
            Console.WriteLine("Kör sugara: {0}", sugar);

            var district = Math.Round((Math.PI * 2 * sugar), 3);
            var area = Math.Round((Math.Pow(sugar, 2) * Math.PI), 3);

            Console.WriteLine("A kör kerülete: {0}", district);
            Console.WriteLine("A kör területe: {0}", area);*/

            /* Console.WriteLine("Kérem adjon meg egy számot!");
             var bevitel = Console.ReadLine();

             int x = Convert.ToInt32(bevitel);

             if (x >= 20) Console.WriteLine("Nagyobb, vagy egyenlő , mint 20");
             else if (x >= 10) Console.WriteLine("Nagyobb, vagy egyenlő, mint 10");
             else Console.WriteLine("Kisebb, mint 10");

             //Komplex feltétel, zárójelezés fontos!
             if (((x % 2) == 0) && (x > 0))
             {
                 Console.WriteLine("A megadott szám páros és nem nulla");
             }
             else Console.WriteLine("Páratlan vagy nulla");*/


            /*if (Teszt1() & Teszt2())
            {
                //Mindkét metódus lefut a tesztelés közben
            }
            Console.WriteLine();

            if (Teszt2() | Teszt1())
            {
                //Mindkét metódus lefut a tesztelés közben
            }
            Console.WriteLine();

            if (Teszt1() && Teszt2())
            {
                //Teszt2 nem hívódik meg
            }
            Console.WriteLine();

            if (Teszt2() || Teszt1())
            {
                //Teszt1 nem hívódik meg
            }*/

            Console.WriteLine("Menü program");
            Console.WriteLine("Opciók:");
            Console.WriteLine("A: Kis kávé, B: Nagy kávé");
            Console.WriteLine("C: Nem iszom semmit");
            Console.Write("Kérem válasszon!: ");
            var gomb = (char)Console.Read();

            if (gomb == 'A' || gomb == 'a')
            {
                Console.WriteLine("Kis kávét választott");
            }
            else if (gomb == 'B' || gomb == 'b')
            {
                Console.WriteLine("Nagy kávét választott");
            }
            else if (gomb == 'C' || gomb == 'c')
            {
                Console.WriteLine("Kár");
            }
            else
            {
                Console.WriteLine("Nem jó gombot nyomott!");
            }
            Console.ReadLine();
        }
    }
}