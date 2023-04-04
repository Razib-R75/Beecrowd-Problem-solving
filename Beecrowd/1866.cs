using System;

class Program {
    static void Main(string[] args) {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++) {
            int x = int.Parse(Console.ReadLine());
            int result = x % 2 == 0 ? 0 : 1;
            Console.WriteLine(result);
        }
    }
}