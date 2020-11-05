using System;
using System.Data;

namespace Zjazd4
{
    public class Product
    {
        public int Id;
        public string Nazwa;
        public decimal Cena;
        public string KodKreskowy;
        public decimal Stan;
    }

    public class Transakcja
    {
        public int Id;
        public DataSetDateTime Czas;
        public decimal Kwota;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Product nowyProdukt = new Product();
            Console.WriteLine("Hello World!");
        }
    }
}
