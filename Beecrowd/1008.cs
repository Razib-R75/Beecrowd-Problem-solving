using System;


namespace uri1008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, H;
            float P, S;
            N = Convert.ToInt32(Console.ReadLine());
            H = Convert.ToInt32(Console.ReadLine());
            P = float.Parse(Console.ReadLine());
            S = (H*P);
            Console.WriteLine($"NUMBER = {N}");
            Console.WriteLine($"SALARY = U$ {S.ToString("f2")}");
            Console.ReadKey();

        }
    }
}