using System;

class Program
{
    static void Main(string[] args)
    {
        int x, y;

        while (true)
        {
            string[] input = Console.ReadLine().Split();
            x = int.Parse(input[0]);
            y = int.Parse(input[1]);

            if (x == y)
                break;

            if (x < y)
                Console.WriteLine("Crescente");
            else
                Console.WriteLine("Decrescente");
        }
    }
}

