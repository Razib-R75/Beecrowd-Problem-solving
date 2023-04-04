using System;

class Program {
    static void Main(string[] args) {
        int A, B;
        string[] input = Console.ReadLine().Split();

        A = int.Parse(input[0]);
        B = int.Parse(input[1]);

        if (B % A == 0 || A % B == 0) {
            Console.WriteLine("Sao Multiplos");
        } else {
            Console.WriteLine("Nao sao Multiplos");
        }
    }
}
