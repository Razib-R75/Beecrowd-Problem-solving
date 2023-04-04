using System;

class Program {
    static void Main(string[] args) {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++) {
            double food = double.Parse(Console.ReadLine());
            int days = 0;

            while (food > 1) {
                food /= 2;
                days++;
            }

            Console.WriteLine("{0} dias", days);
        }
    }
}