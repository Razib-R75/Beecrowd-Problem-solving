using System;
namespace hello_1005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float A, B;
            Double MEDIA;

            A = float.Parse(Console.ReadLine());


            B = float.Parse(Console.ReadLine());

            MEDIA =((A*3.5)+(B*7.5))/(3.5+7.5);
            
            Console.WriteLine($"MEDIA = {MEDIA.ToString("f5")}");

            Console.ReadKey();

        }
    }
}