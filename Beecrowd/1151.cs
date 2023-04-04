using System;

class MainClass {
  public static void Main (string[] args) {
    int n = int.Parse(Console.ReadLine());
    int a = 0, b = 1;
    Console.Write($"{a} {b}");
    for (int i = 2; i < n; i++) {
      int c = a + b;
      Console.Write($" {c}");
      a = b;
      b = c;
    }
    Console.WriteLine();
  }
}
