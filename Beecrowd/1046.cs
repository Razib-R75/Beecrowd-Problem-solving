using System;

class Program {
    static void Main(string[] args) {
        int a, b;
        string[] input = Console.ReadLine().Split();

        a = int.Parse(input[0]);
        b = int.Parse(input[1]);

        if (a == b) {
            Console.WriteLine("O JOGO DUROU {0} HORA(S)", 24 - a + b);
        } else if (a <= b) {
            Console.WriteLine("O JOGO DUROU {0} HORA(S)", b - a);
        } else {
            Console.WriteLine("O JOGO DUROU {0} HORA(S)", 24 - a + b);
        }

        return;
    }
}
