using System;
namespace uri1002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A, R, pi;
            pi=3.14159;
            R = Convert.ToDouble(Console.ReadLine());
            A = pi*(R*R);
            Console.WriteLine($"A={A.ToString("f4")}");

            Console.ReadKey();

        }
    }
}