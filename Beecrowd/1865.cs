using System;

class Program {
    static void Main(string[] args) {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++) {
            string[] input = Console.ReadLine().Split();

            string name = input[0];
            int level = int.Parse(input[1]);

            if (name == "Thor") {
                Console.WriteLine("Y");
            } else {
                Console.WriteLine("N");
            }
        }
    }
}