using System;

namespace uri1017
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, Y, R;
            Double Z;
            X = Convert.ToInt32 (Console.ReadLine());
            Y = Convert.ToInt32(Console.ReadLine());
            R = X * Y;
            Z = (1.0/12.0)* R;
            Console.WriteLine(Z.ToString("f3"));
            Console.ReadKey();
        }
    }
}