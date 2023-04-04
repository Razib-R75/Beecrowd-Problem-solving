using System;

class Program {
    static void Main(string[] args) {
        string line;
        while ((line = Console.ReadLine()) != null) {
            string[] numbers = line.Split();
            uint a = uint.Parse(numbers[0]);
            uint b = uint.Parse(numbers[1]);
            uint c = a ^ b; // bitwise XOR
            Console.WriteLine(c);
        }
    }
}