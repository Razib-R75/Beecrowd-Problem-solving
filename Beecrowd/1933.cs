using System;

class Program {
    static void Main() {
        string[] input = Console.ReadLine().Split();
        int a = int.Parse(input[0]);
        int b = int.Parse(input[1]);
        
        if (a == b) Console.WriteLine(a);
        else Console.WriteLine(Math.Max(a, b));
    }
}
