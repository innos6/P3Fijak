using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;


namespace Zadanie7
{
    interface IPrintable
    {
        void print();
    }


    class test : object, ICloneable, IComparable<test>, IPrintable
    { 
        public int _id { get; set; }
        public string _tekst { get; set; }
        public int[] _tab { get; set; }

        public test(int id, string tekst, int[] tab)
        {
            _id = id;
            _tekst = tekst;
            _tab = tab;
        }
        public test(test previousObject) {
            _id = previousObject._id;
            _tekst = previousObject._tekst;
            _tab = new int[10];
            for (int i = 0; i < 10; i++)
            {
                this._tab[i] = previousObject._tab[i];
            }
        }


        public object Clone()
        {
            test buffer = new test(this);
            
            
            return buffer;
        }

        public int CompareTo(test other)
        {
            return this._tekst.CompareTo(other._tekst);
        }

        public void print()
        {
            Console.WriteLine("Id: "+this._id);
            Console.WriteLine("Tekst: "+this._tekst);
            int i = 1;
            foreach (var item in this._tab)
            {
                Console.WriteLine("Wartość "+(i++)+" z tablicy: "+item);

            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //----------------------------Generatory wartości--------------------
            Random random = new Random();
            string RandomString(int length)
            {
                const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                return new string(Enumerable.Repeat(chars, length)
                  .Select(s => s[random.Next(s.Length)]).ToArray());
            }
            //-------------------------------------------------------------------

            test[]tablica = new test[100];
            for (int i = 0; i < 100; i++)
            {
                int[] bufferTab = new int[10];
                for (int j = 0; j < 10; j++)
                {
                    bufferTab[j] = random.Next(100);
                }
                test buffer = new test(i+1, RandomString(5), bufferTab);
                tablica[i] = buffer;
            }

            List<test> lista = new List<test>();
            for (int i = 0; i < 100; i++)
            {
                lista.Add((test)tablica[i].Clone());
            }
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    tablica[i]._tab[j] = 0;
                }
            }

            lista.Sort();
            foreach (test item in lista)
            {
                item.print();
            }
        }
    }
}
