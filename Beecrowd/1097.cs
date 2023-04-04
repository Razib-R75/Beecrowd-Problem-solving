using System;

class MainClass {
  public static void Main (string[] args) {
    int i, j;

    for (i = 1; i <= 9; i += 2) {
      for (j = 6 + i; j > 3 + i; j--) {
        Console.WriteLine($"I={i} J={j}");
      }
    }
  }
}