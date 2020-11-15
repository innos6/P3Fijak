using System;

namespace Kolokwium1
{
    class Produkt
    {
        public static int counter =0;
        public string Nazwa { get; set; }
        public int Ilosc { get; set; }
        public float Cena { get; set; }
        public Produkt(string x, int y, float z)
        {
            this.Nazwa = x;
            this.Ilosc = y;
            this.Cena = z;
            counter++;
        }
        public Produkt()
        {
            this.Nazwa = "";
            this.Ilosc = 0;
            this.Cena = 0f;
            counter++;
        }
        ~Produkt()
        { 
            counter--;
        }
    }


    class Zawodnik
    {
        public int NumerStartowy { get; set; }
        public string Nazwisko { get; set; }
        public int Godzina { get; set; }
        public int Minuta { get; set; }
        public int Sekunda { get; set; }

        
    }


    class Program
    {
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

        public static float oblicz(float x, float y, float z)
        {
            var kcal = (x * 9.45f) + (y * 4.15f) + (z * .65f);
            return kcal * 100f / 2000f;
        }
        public static void Zadanie1()
        {
            float tluszcz, wegle, bialko;
            Console.WriteLine("Podaj ile tłuszczu: ");
            tluszcz = GetParam();
            Console.WriteLine("Podaj ile wegli: ");
            wegle = GetParam();
            Console.WriteLine("Podaj ile bialka: ");
            bialko = GetParam();
            Console.WriteLine("zjadles " + oblicz(tluszcz, wegle, bialko) + " % dziennego zapotrzebowania na KCal");
            Console.WriteLine("Mozesz zjesc jeszcze : " + 100 / oblicz(tluszcz, wegle, bialko) + " takich porcji.");
        }

        public static void WypiszFakture(Produkt[] tab)
        {
            int i=1;
            foreach (var item in tab)
            {
                Console.WriteLine("Faktura: ");
                Console.WriteLine(i+" "+item.Nazwa+" "+item.Ilosc + " " +item.Cena + " " +item.Cena*item.Ilosc + " " + item.Cena * item.Ilosc*1.23f);
                i++;
            }
            float sumaNetto, sumaBrutto;

        }

        public static void Zadanie2()
        {
            Produkt []paragon1 = new Produkt[3];
            Produkt[] paragon2 = new Produkt[4];
            paragon1[0] = new Produkt("Mleko", 2, 3.50f);
            paragon1[1] = new Produkt("Jajka", 1, 4.50f);
            paragon1[2] = new Produkt("Kakao", 1, 2f);

            paragon2[0] = new Produkt("Chipsy", 1, 2f);
            paragon2[1] = new Produkt("Chleb", 1, 4.50f);
            paragon2[2] = new Produkt("Cola", 1, 5f);
            paragon2[3] = new Produkt("Papierosy", 1, 16.50f);
            WypiszFakture(paragon1);
            WypiszFakture(paragon2);
        }

        public static void Zadanie3()
        {

        }

        static void Main(string[] args)
        {
            Zadanie1();
            Zadanie2();
        }
    }
}
