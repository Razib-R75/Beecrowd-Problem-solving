using System;

class Program {
    static void Main(string[] args) {
        string[] input = Console.ReadLine().Split();
        int[] sockets = Array.ConvertAll(input, int.Parse);
        int total = sockets[0] + sockets[1] + sockets[2] + sockets[3] - 3;

        Console.WriteLine(total);
    }
}