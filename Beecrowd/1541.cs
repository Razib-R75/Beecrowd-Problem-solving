using System;

class Program {
    static void Main(string[] args) {
        while (true) {
            string[] input = Console.ReadLine().Split(' ');
            if (input[0] == "0") break;

            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int c = int.Parse(input[2]);

            int area = (int)Math.Sqrt((a * b * 100) / c);
            Console.WriteLine(area);
        }
    }
}
