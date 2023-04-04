using System;

class Program {
    static void Main(string[] args) {
        int n, x;

        n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++) {
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} kg", (long)(Math.Pow(2, x) / 12000));
        }
    }
}