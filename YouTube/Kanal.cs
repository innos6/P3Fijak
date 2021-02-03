using System;

namespace YouTube 
{
    internal static class Metody
    {
        public static string info(this Kanal x)
        {
            return "Nazwa: "+x.nazwa + " Subskrypcje: " + x.liczbaSubskrybentow + " Wyświetlenia: " + x.licznikWyswietlen;
        }
    }

    class Kanal 
    {
        public static int licznikId =0;
        public int id { get; set; }
        public string nazwa { get; set; }
        public int licznikWyswietlen { get; set; }
        public int liczbaSubskrybentow;

        public Kanal(string nazwa)
        {
            this.id = licznikId + 1;
            licznikId++;
            this.nazwa = nazwa;
            this.liczbaSubskrybentow = 0;
            this.licznikWyswietlen = 0;
            
        }

        public void wyswietlFilm(int id)
        {
            licznikWyswietlen++;
        }
        public void OpublikujFilm()
        {
            OnOpubikowanoFilm();
            //opublikowano film!!!
        }
        public delegate void OpublikowanoFilmEventHandler(Object o, EventArgs e);
        public event OpublikowanoFilmEventHandler OpublikowanoFilm;

        protected virtual void OnOpubikowanoFilm()
        {
            if (OpublikowanoFilm!=null)
            {
                OpublikowanoFilm(this, EventArgs.Empty);
            }
        }

        public void OnSubscribed(Object o, EventArgs e)
        {
            this.liczbaSubskrybentow++;
        }

    }
}
