using System;
using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Position {
    public int regal { get; set; }
    public int polka { get; set; }
    public int miejsce { get; set; }
    public Position() {
        this.regal = 0;
        this.polka = 0;
        this.miejsce = 0;
    }
    public Position(int x, int y, int z)    {
        this.regal = x;
        this.polka = y;
        this.miejsce = z;
    }
    public Position(Position pos) {
        this.regal = pos.regal;
        this.polka = pos.polka;
        this.miejsce = pos.miejsce;
    }

}

class Ksiazka {
    public static int counter;
    public string tytul { get; set; }
    public string autor { get; set; }
    public Position pozycja { get; set; }
    public Ksiazka() {
        this.tytul = "default";
        this.autor = "default";
        this.pozycja = new Position();
        Ksiazka.counter++;
    }
    public Ksiazka(string x, string y, Position pos) {
        this.tytul = x;
        this.autor = y;
        this.pozycja = pos;
        Ksiazka.counter++;
    }
    ~Ksiazka()  {
        Ksiazka.counter--;
    }
}

namespace Zadanie4 {
    class Program    {
        public static Position szukaj(ref Ksiazka [,,]tab, string pharse) {
            for (int i = 0; i < tab.GetLength(0); i++) {
                for (int j = 0; j < tab.GetLength(1); j++) {
                    for (int k = 0; k < tab.GetLength(2); k++) {
                        if ((tab[i,j,k].autor.Contains(pharse)) || (tab[i, j, k].tytul.Contains(pharse))) {
                            return tab[i,j,k].pozycja;
                        }
                    }
                }
            }
            return new Position(99, 99, 99);
        }

        static void Main(string[] args) {
            Ksiazka[,,] biblioteka = new Ksiazka[3,6,10];
            for (int i = 0; i < biblioteka.GetLength(0); i++) {
                for (int j = 0; j < biblioteka.GetLength(1); j++) {
                    for (int k = 0; k < biblioteka.GetLength(2); k++) {
                        biblioteka[i, j, k] = new Ksiazka();
                        biblioteka[i, j, k].pozycja.regal = i;
                        biblioteka[i, j, k].pozycja.polka = j;
                        biblioteka[i, j, k].pozycja.miejsce = k;
                    }
                }
            }
            biblioteka[2, 1, 4].autor = "Andrzej Sapkowski";
            biblioteka[2, 1, 4].tytul = "Pani jeziora";
            biblioteka[1, 3, 9].autor = "Andrzej Sapkowski";
            biblioteka[1, 3, 9].tytul = "Chrzest ognia";
            Console.WriteLine("Podaj frazę której szukamy w polach Autor lub Tytuł : ");
            string phrase = Console.ReadLine();
            Position tempPos = Program.szukaj(ref biblioteka, phrase);
            if (tempPos.regal == 99) { 
                Console.WriteLine("Ksiazka nie znaleziona.");
            }else  {
                Console.WriteLine("Szukana ksiazka jest w " + tempPos.regal + " regale, na " + tempPos.polka + " półce, na " + tempPos.miejsce + " miejcu.");
            }
        }
    }
}
