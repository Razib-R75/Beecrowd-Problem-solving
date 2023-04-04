using System;

class Program {
    static void Main(string[] args) {
        int n;
        while (int.TryParse(Console.ReadLine(), out n)) {
            if (n == 0) Console.WriteLine("vai ter copa!");
            else Console.WriteLine("vai ter duas!");
        }
    }
}
