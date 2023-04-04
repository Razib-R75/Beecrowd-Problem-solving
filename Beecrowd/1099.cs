using System;

class Program {
    static void Main(string[] args) {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++) {
            string[] input = Console.ReadLine().Split();

            int x = int.Parse(input[0]);
            int y = int.Parse(input[1]);

            int sum = 0;

            if (x > y) {
                int temp = x;
                x = y;
                y = temp;
            }

            for (int j = x + 1; j < y; j++) {
                if (j % 2 != 0) {
                    sum += j;
                }
            }

            Console.WriteLine(sum);
        }

        return;
    }
}
