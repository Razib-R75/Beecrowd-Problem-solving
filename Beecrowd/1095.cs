
using System;

class MainClass {
  public static void Main (string[] args) {
    for (int i = 1, j = 60; j >= 0; i += 3, j -= 5) {
      Console.WriteLine($"I={i} J={j}");
    }
  }
}
