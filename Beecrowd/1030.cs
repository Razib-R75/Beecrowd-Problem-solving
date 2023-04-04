using System;

class Program {
    static void Main(string[] args) {
        int t = int.Parse(Console.ReadLine());
        for (int i = 1; i <= t; i++) {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int k = int.Parse(input[1]);
            int survivor = Josephus(n, k);
            Console.WriteLine($"Case {i}: {survivor}");
        }
    }

    static int Josephus(int n, int k) {
        int survivor = 0;
        for (int i = 2; i <= n; i++) {
            survivor = (survivor + k) % i;
        }
        return survivor + 1;
    }
}
