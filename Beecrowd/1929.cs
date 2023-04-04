using System;

class Program {
    static void Main(string[] args) {
        string[] input = Console.ReadLine().Split();
        int[] sides = Array.ConvertAll(input, int.Parse);
        Array.Sort(sides);

        if (sides[0] + sides[1] > sides[2] || sides[1] + sides[2] > sides[3]) {
            Console.WriteLine("S");
        } else {
            Console.WriteLine("N");
        }
    }
}