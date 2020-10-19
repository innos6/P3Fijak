using System;

namespace Zadanie_3
{
    class Program
    {
        public static int addup(ref int [][]x)
        {
            int suma = 0;

            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x[i].GetLength(0); j++)
                {
                    suma += x[i][j];
                }
            }

            return suma;
        }
        public static void fillAuto(ref int[][] x)
        {          
            Random rnd = new Random();
            int w;
            for (int i = 0; i < x.GetLength(0); i++)
            {
                w = rnd.Next(10)+1;
                x[i] = new int[w];
                for (int j = 0; j < w; j++)
                {
                    x[i][j] = rnd.Next(50)+1;
                }
            }
        }
        public static void wypisz(ref int[][] x)
        {
            for (int i = 0; i < x.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < x[i].GetLength(0); j++)
                {
                    Console.Write(x[i][j]+" ");
                }
            }
        }

        public static void initialize(ref int[][] x)
        {
            for (int i = 0; i < x.GetLength(0); i++)
            {
                Console.Clear();
                Console.WriteLine("Ile kolumn w "+(i+1)+" wierszu? : ");
                int w = int.Parse(Console.ReadLine());
                x[i] = new int[w];
                for (int j = 0; j < w; j++)
                {
                    Console.WriteLine("Co w "+(j+1)+" kolumnie? : ");
                    x[i][j] = int.Parse(Console.ReadLine());
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Podaj ile wierszy ma mieć tablica : ");
            var k = int.Parse(Console.ReadLine());
            int[][] tab = new int[k][];
            Console.WriteLine("Chcesz wypełnić samodzielnie? y/n ");
            switch (Console.ReadLine())
            {
                case "y": { initialize(ref tab); break; }
                case "n": { fillAuto(ref tab); break; }
            }
            wypisz(ref tab);
            Console.WriteLine();
            Console.WriteLine("Suma elementów = "+addup(ref tab));
        }
    }
}
