using System;
namespace hello_world_tb
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Double  A, B, C, MEDIA;

            A = Convert.ToDouble (Console.ReadLine());
            B = Convert.ToDouble(Console.ReadLine());
            C = Convert.ToDouble(Console.ReadLine());

            MEDIA = ((A*2)+(B*3)+(C*5))/(2+3+5);

            Console.WriteLine($"MEDIA = {MEDIA.ToString("f1")}");

            Console.ReadKey();

        }
    }
}