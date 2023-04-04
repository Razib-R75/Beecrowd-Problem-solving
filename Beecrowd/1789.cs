using System;

class Program {
    static void Main(string[] args) {
        while (true) {
            string line = Console.ReadLine();
            if (string.IsNullOrEmpty(line)) break;

            int.TryParse(line, out int n);
            string[] speeds = Console.ReadLine().Split();

            int maxSpeed = 0;
            for (int i = 0; i < n; i++) {
                int.TryParse(speeds[i], out int speed);
                maxSpeed = Math.Max(maxSpeed, speed);
            }

            int level = 0;
            if (maxSpeed < 10) level = 1;
            else if (maxSpeed < 20) level = 2;
            else level = 3;

            Console.WriteLine(level);
        }
    }
}
