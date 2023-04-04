using System;

public class GFG
{
    static int bigmod(long n, int M)
    {
        if (n <= 0) return 0;

        long a = 1, b = 0, c = 0, d = 1, r;
        --n;

        while (n > 0)
        {
            if ((n & 1) != 0)
            {
                r = (d * b + c * a) % M;
                b = (d * (b + a) + c * b) % M;
                a = r;
            }

            r = (c * c + d * d) % M;
            d = (d * (2 * c + d)) % M;
            c = r;

            n = n / 2;
        } return (int)((a + b) % M);
    }

    public static void Main()
    {
        long k;
        int g, h, re = 0;

        while (true)
        {
            string[] input = Console.ReadLine().Split();

            k = Convert.ToInt64(input[0]);
            g = Convert.ToInt32(input[1]);

            if (k == 0 && g == 0)
                break;

            h = ((2 * bigmod(k + 1, g)) - 1 + g) % g;
            Console.WriteLine("Case " + (++re) + ": " + k + " " + g + " " + h);
        }
    }
}
