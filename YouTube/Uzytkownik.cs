using System;

namespace YouTube {
    class Uzytkownik {
        public Uzytkownik(int id, string nazwa)
        {
            this.id = id;
            this.nazwa = nazwa;
        }

        private int id { get; set; }
        private string nazwa { get; set; }
        public void subskrybujKanal(Kanal x) {
            x.OpublikowanoFilm += this.OnOpublikowanoFilm;
            this.Subscribed += x.OnSubscribed;
            OnSubscribed();
        }
        public void OnOpublikowanoFilm(Object o, EventArgs e)
        {
            Console.WriteLine($@"Użytkownik {this.nazwa} otrzymał powiadomienie o nowym filmie.");
        }

        public delegate void SubscibedEventHandler(Object o, EventArgs e);
        public event SubscibedEventHandler Subscribed;

        protected virtual void OnSubscribed()
        {
            if (Subscribed != null)
            {
                Subscribed(this, EventArgs.Empty);
            }
        }

    }
}
