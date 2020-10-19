using System;
using System.Linq;

namespace Zadanie_3._2 {
    class Program    {
        public static string format(string x) {
            string buffer="";
            if (x.Last() != '.') {
                x += ('.');
            }
            var tab = new char[x.Length];
            tab = x.ToCharArray();
            if ((tab[0] >= 97)&&(tab[0] <= 122)) {
                tab[0] -= (char)32;
                for (int i = 0; i < tab.Length; i++) {
                    buffer+=tab[i];
                }
            }
            return buffer;
        }
        static void Main(string[] args) {
            string a = "ala ma kota";
            Console.WriteLine(a);
            Console.WriteLine(format(a));
        }
    }
}
