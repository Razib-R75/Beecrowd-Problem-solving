using System;

class Program {
    static int Remaining(int n, int k) {
        int r = 0;
        for (int i = 1; i < n; i++) {
            r = (r + k) % i;
        }

        return r;
    }

    static void Main() {
        int n, x, y, j, num, pulo;
        while (true) {
            n = int.Parse(Console.ReadLine());
            if (n == 0) {
                break;
            }
            y = 1;
            for (;;) {
                if (Remaining(n, y) != 11) {
                    y++;
                }
                else {
                    break;
                }
            }
            Console.WriteLine(y);
        }
    }
}
