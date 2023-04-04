using System;

class Program {
    static void Main(string[] args) {
        int n;
        while (int.TryParse(Console.ReadLine(), out n) && n != 0) {
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    if (i + j == n - 1) Console.Write(2);
                    else if (i == j) Console.Write(1);
                    else Console.Write(3);
                }
                Console.WriteLine();
            }
        }
    }
}
