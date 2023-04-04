using System;

class MainClass {
  public static void Main (string[] args) {
    int n = int.Parse(Console.ReadLine());
    int count = 0;

    for (int i = 0; i < n; i++) {
        int x = int.Parse(Console.ReadLine());
        if (x >= 10 && x <= 20) {
            count++;
        }
    }

    Console.WriteLine(count + " in");
    Console.WriteLine((n - count) + " out");
  }
}