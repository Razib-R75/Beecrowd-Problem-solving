using System;
namespace hello_world_tb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D, DIFERENCA;

            A = Convert.ToInt32(Console.ReadLine());
            B = Convert.ToInt32(Console.ReadLine());
            C = Convert.ToInt32(Console.ReadLine());
            D = Convert .ToInt32(Console.ReadLine());
            DIFERENCA= (A*B)-(C*D);
            Console.WriteLine($"DIFERENCA = {DIFERENCA}");

            Console.ReadKey();

        }
    }
}