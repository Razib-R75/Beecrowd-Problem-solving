using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();
            int x = int.Parse(input[0]);
            int y = int.Parse(input[1]);

            if (y == 0)
                Console.WriteLine("divisao impossivel");
            else
            {
                double result = (double)x / y;
                Console.WriteLine("{0:0.0}", result);
            }
        }
    }
}

