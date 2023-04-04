using System;

namespace _1037_Intervalo
{
    class Program
    {
        static void Main(string[] args)
        {
            float X = float.Parse(Console.ReadLine());

            if (X >= 0.0 && X <= 25.0)
            {
                Console.WriteLine("Intervalo [0,25]");

            }
            else if (X > 25.0 && X <= 50.0)
            {
                Console.WriteLine("Intervalo (25,50]");

            }
            else if (X > 50.0 && X <= 75.0)
            {
                Console.WriteLine("Intervalo (50,75]");
                ;
            }
            else if (X > 75.0 && X <= 100.0)
            {
                Console.WriteLine("Intervalo (75,100]");

            }
            else
            {
                Console.WriteLine("Fora de intervalo");
            }

            

        }
    }
}