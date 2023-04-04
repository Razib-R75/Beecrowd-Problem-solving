using System;

class Program {
    static void Main() {
        int v = int.Parse(Console.ReadLine());
        string hex = v.ToString("X");
        Console.WriteLine(hex);
    }
}
