using System;

class MainClass {
  public static void Main (string[] args) {
    int n = int.Parse(Console.ReadLine());

    for (int i = 0; i < n; i++) {
        int x = int.Parse(Console.ReadLine());
        if (x == 0) {
            Console.WriteLine("NULL");
        }
        else if (x % 2 == 0) {
            Console.WriteLine(x > 0 ? "EVEN POSITIVE" : "EVEN NEGATIVE");
        }
        else {
            Console.WriteLine(x > 0 ? "ODD POSITIVE" : "ODD NEGATIVE");
        }
    }
  }
}