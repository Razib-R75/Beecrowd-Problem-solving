using System;

class URI1161 {
    static void Main(string[] args) {
        int n, m;

        while (true) {
            try {
                string[] input = Console.ReadLine().Split(' ');

                n = int.Parse(input[0]);
                m = int.Parse(input[1]);

                long factorialN = CalculateFactorial(n);
                long factorialM = CalculateFactorial(m);

                Console.WriteLine(factorialN + factorialM);
            } catch {
                break;
            }
        }
    }

    static long CalculateFactorial(int number) {
        if (number <= 1) {
            return 1;
        }

        long result = number;

        for (int i = number - 1; i > 1; i--) {
            result *= i;
        }

        return result;
    }
}
