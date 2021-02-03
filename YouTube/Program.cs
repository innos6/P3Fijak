using System;
using System.Collections.Generic;

namespace YouTube {
    class Program {
        static void Main(string[] args) {
            Kanal HowToBasic = new Kanal("HowToBasic");
            List<Uzytkownik> UsersList = new List<Uzytkownik>();
            for (int i = 1; i <= 100; i++)
            {
                UsersList.Add(new Uzytkownik(i,"User" + i));    
            }
            foreach (var item in UsersList)
            {
                item.subskrybujKanal(HowToBasic);
            }
            HowToBasic.OpublikujFilm();
            Console.WriteLine(HowToBasic.info());
        }
    }
}
