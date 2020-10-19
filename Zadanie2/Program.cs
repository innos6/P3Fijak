using System;

namespace Zadanie2
{

    public enum wynik 
    { 
        ujemny = 0,
        zero = 1,
        dodatni = 2
        
    }

    class Program
    {
        static public wynik i;
        static float GetParam()
        {
            bool guard = false;
            var a = Console.ReadLine();
            float _ConvertedA = 0;
            while (!guard)
            {
                if ((float.TryParse(a, out _ConvertedA)) == false)
                {
                    Console.WriteLine("Niezgodny typ danych, sprobuj jeszcze raz: ");
                    a = Console.ReadLine();
                }
                else
                {
                    guard = true;
                }
            }
            return _ConvertedA;
        }
        static float Delta(float a, float b, float c)
        {
            return (b * b) - (4 * a * c);
        }
        static void Main(string[] args)
        {
                
        Console.WriteLine("Podaj parametry a,b,c dla postaci f(x)=ax^2+bx+c aby znalezc jej rozwiazania.");
            Console.WriteLine("Podaj a : ");
            float a = GetParam();
            Console.WriteLine("Podaj b : ");
            float b = GetParam();
            Console.WriteLine("Podaj c : ");
            float c = GetParam();
            var delta = Delta(a, b, c);
            Console.WriteLine("Delta wynosi : "+ delta);
            if (delta > 0)
            {
                i = wynik.dodatni;
            }
            else if (delta < 0)
            {
                i = wynik.ujemny;
            }
            else if (delta == 0)
            {
                i = wynik.zero;
            }

            switch (i)
            {
                case wynik.ujemny:
                    Console.WriteLine("Brak rozwiazan w zbiorze liczb rzeczywistych.");
                    break;
                case wynik.zero:
                    Console.WriteLine("x = "+ (-b)/(2*a));
                    break;
                case wynik.dodatni:
                    Console.WriteLine("x1 = " + ( ( (-b) - Math.Sqrt(delta) ) / (2*a) ) );
                    Console.WriteLine("x2 = " + ( ( (-b) + Math.Sqrt(delta) ) / (2*a) ) );
                    break;
            }
        }
    }
}
