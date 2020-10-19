using System;

namespace Zjazd3
{
    class Program
    {
        static void Wypisz(int[] tab) {
            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine(tab[i]);
            }
            
        }
        static void Main(string[] args)
        {
            int[] tab = new int[10];
            int[] tab2 = {1, 1, 0, 3, 5, 8, 0 };

            int[,] tabxy = new int[10, 7];

            int[][] tabTab = new int[4][];

            for (int i = 0; i < tabTab.Length; i++)
            {
                tabTab[i] = new int[i + 1];
            }

            for (int i = 0; i < tabTab.Length; i++)
            {
               
                for (int j = 0; j < tabTab[i].Length; j++)
                {
                    Console.WriteLine(tabTab[i][j] + " ");
                }
                Console.WriteLine();
            }

            //for (int i = 0; i < tabxy.GetLength(0); i++)
            //{
            //    Console.WriteLine();
            //    for (int j = 0; j < tabxy.GetLength(1); j++)
            //    {
            //        Console.Write(tabxy[i,j]+ " ");
            //    }
            //}


            //for (int i = 0; i < tab.Length; i++)
            //{
            //    tab[i] = i;
            //}
            //Wypisz(tab2);

        }
    }
       
}
