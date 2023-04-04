using System;

class Program
{
    static void Main(string[] args)
    {
        int m, n, sum;

        while (true)
        {
            string[] input = Console.ReadLine().Split();
            m = int.Parse(input[0]);
            n = int.Parse(input[1]);

            if (m <= 0 || n <= 0)
                break;

            if (m > n)
            {
                int temp = m;
                m = n;
                n = temp;
            }

            sum = 0;
            for (int i = m; i <= n; i++)
            {
                Console.Write("{0} ", i);
                sum += i;
            }

            Console.WriteLine("Sum={0}", sum);
        }
    }
}
