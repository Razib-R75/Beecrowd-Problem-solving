using System;

namespace uri_1018
{
    class Program
    {
        static void Main(string[] args)
        {
            int am, n;
            am = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(am);
            Console.WriteLine(am / 100 + " nota(s) de R$ 100,00");
            n = am % 100;
            Console.WriteLine(n / 50 + " nota(s) de R$ 50,00");
            n %= 50;
            Console.WriteLine(n / 20 + " nota(s) de R$ 20,00");
            n %= 20;
            Console.WriteLine(n / 10 + " nota(s) de R$ 10,00");
            n %= 10;
            Console.WriteLine(n/ 5 + " nota(s) de R$ 5,00");
            n %= 5;
            Console.WriteLine(n / 2 + " nota(s) de R$ 2,00");
            n %= 2;
            Console.WriteLine(n / 1 + " nota(s) de R$ 1,00");

            Console.ReadKey();
        }
    }
}