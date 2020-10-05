using System;

namespace Zjazd2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Podaj liczbe: ");
            var odp = Console.ReadLine();
            Console.WriteLine("wpisane slowo: " + odp);
            try
            {
                Console.WriteLine($"wpisane slowo: {Convert.ToInt32(odp) + 4 }");
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            
        }
    }
}
