using System;

class Program
{
    static void Main()
    {
        double[,] M = new double[12, 12];
        double sum = 0.0;
        char[] O = new char[2];
        O = Console.ReadLine().ToCharArray();
        int n = 11, o = 1, i, j;
        for (i = 0; i < 12; i++)
        {
            for (j = 0; j < 12; j++)
            {
                M[i, j] = double.Parse(Console.ReadLine());
            }
        }
        for (i = 0; i < 5; i++)
        {
            for (j = o; j < n; j++)
            {
                sum += M[j, i];
            }
            n--;
            o++;
        }
        if (O[0] == 'S') Console.WriteLine("{0:F1}", sum);
        else Console.WriteLine("{0:F1}", sum / 30.0);
    }
}
