using System;

class Program {
    static void Main(string[] args) {
        int X = int.Parse(Console.ReadLine());
        int Z = int.Parse(Console.ReadLine());

        while (Z <= X) {
            Z = int.Parse(Console.ReadLine());
        }

        int sum = X;
        int count = 1;
        while (sum <= Z) {
            X++;
            sum += X;
            count++;
        }

        Console.WriteLine(count);
    }
}
