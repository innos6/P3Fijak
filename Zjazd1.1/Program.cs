using System;

namespace Zjazd1._1
{
    class Writer
    {
        public
        void WypiszDate()
        {
            Console.WriteLine(DateTime.Now);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Writer writer = new Writer();
            writer.WypiszDate();
        }

    }

    

}
