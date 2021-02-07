using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace kolos2
{
    class List 
    {
        public string Tresc { get; set;  }

        public List(string tresc)
        {
            Tresc = tresc;
        }
    }


    class Wiadomosc<isclass>
        {
        private string v1;
        private string v2;
        private email email;

        public string nadawca { get; set; }
            public string odbiorca { get; set; }
            public List list { get; set; }

        public Wiadomosc(string nadawca, string odbiorca, List list)
        {
            this.nadawca = nadawca;
            this.odbiorca = odbiorca;
            this.list = list;
        }

        public Wiadomosc(string v1, string v2, email email)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.email = email;
        }
    }
    class email
    { 
        public string temat { get; set; }
        public string mail { get; set; }
    }


    class Program
    {
        
        static void Main(string[] args)
        {
            ///zad 1
            ///
             List<int> lista = new List<int>();



            Random rnd = new Random();
            for (int i = 1; i < 32; i++)
            {
                lista.Add(rnd.Next(100));
            }
            int kiedyMax()
            {
                int pos = lista.IndexOf(lista.Max());
                Console.WriteLine("Odnotowano max dnia: "+(pos+1) +" dzien wczesniej bylo: " + lista.ElementAt(pos-1));
                return lista.Max(x => x); 
            }

            int kiedyMin()
            {
                int pos = lista.IndexOf(lista.Min());
                Console.WriteLine("Odnotowano min dnia: " + (pos+1) + " dzien wczesniej bylo: " + lista.ElementAt(pos - 1));
                return lista.Min(x => x);
            }
            foreach (var item in lista)
            {
                Console.WriteLine(item);
                
            }
            Console.WriteLine(kiedyMax()+" "+kiedyMin());



            ////// Zad 2 
            ///
            List list = new List("asdadadaddadadaa");
            Wiadomosc<List> msg = new Wiadomosc<List>("Bart", "Pablo", list);
            Wiadomosc<email> msg2 = new Wiadomosc<email>("Bart", "Pablo", new email());

            /// zad 3
            /// 
            void cloneBackup (string path, string name)
            {
                var text = System.IO.File.ReadAllText(@path+name);
               
                System.IO.File.WriteAllText(@path+name+".backup", text);
            }
            cloneBackup(@"C:\", "mail.txt");
        }
        
    }
}

