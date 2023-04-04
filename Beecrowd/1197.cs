using System;

class Program {
    static void Main(string[] args) {
        string line;
        while ((line = Console.ReadLine()) != null) {
            string[] tokens = line.Split();
            int v = int.Parse(tokens[0]);
            int t = int.Parse(tokens[1]);
            int d = 2 * v * t; // distance = velocity * time
            Console.WriteLine(d);
        }
    }
}