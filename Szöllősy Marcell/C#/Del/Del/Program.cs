internal class Program
{
    delegate void voidDelegate();
    static void Metódus();
    {
    Console.WriteLine("A metódus lefutott");
    }
    static void Main(string[] args)
    {
    voidDelegate vd = new voidDelegate(Metódus);
    Console.ReadKey();
     }
}