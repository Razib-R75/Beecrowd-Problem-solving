using System;

class Program {
    static void Main(string[] args) {
        while (true) {
            int n = int.Parse(Console.ReadLine());
            if (n == 0) break;

            int[,] matrix = new int[n, n];
            int pow = 1;
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    matrix[i, j] = pow;
                    pow *= 2;
                }
                pow = 1 << (i + 1);
            }

            int maxDigits = (int)Math.Log10(matrix[n - 1, n - 1]) + 1;
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    Console.Write("{0," + maxDigits + "}", matrix[i, j]);

                    if (j < n - 1) {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
