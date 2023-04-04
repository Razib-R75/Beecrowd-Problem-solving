using System;

namespace uri__1019
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, h, m, s, R;
         
            X = Convert.ToInt32(Console.ReadLine());
            h = X / 3600;
            R = X % 3600;
            m = R/60;
            R  %= 60;
            s = R;

            Console.WriteLine(h + ":" + m + ":" + s);

            Console.ReadKey();

        }
    }
}