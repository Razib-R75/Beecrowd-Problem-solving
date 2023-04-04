using System;

class Program
{
    static void Main(string[] args)
    {
        double a, b, c = 0, d = 0;
        while (true)
        {
            if (d == 2)
                break;
            if (double.TryParse(Console.ReadLine(), out a))
            {
                if (a >= 0 && a <= 10)
                {
                    d++;
                    c += a;
                }
                else
                    Console.WriteLine("nota invalida");
            }
            else
                Console.WriteLine("valor invalido");
        }
        b = c / 2.00;
        Console.WriteLine("media = {0:0.00}", b);
    }
}
