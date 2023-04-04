using System;
namespace hello_world_tb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, SOMA;

            A = Convert.ToInt32(Console.ReadLine());
            B = Convert.ToInt32(Console.ReadLine());
            SOMA = A+B;
            Console.WriteLine($"SOMA = {SOMA}");

            Console.ReadKey();

        }
    }
}