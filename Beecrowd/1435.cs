using System;

class MainClass {
  public static void Main () {
    int n;
    while ((n = int.Parse(Console.ReadLine())) != 0) {
      for (int i = 1; i <= n; i++) {
        for (int j = 1; j <= n; j++) {
          Console.Write("{0,3}", Math.Min(Math.Min(i, j), Math.Min(n - i + 1, n - j + 1)));
          if (j < n) Console.Write(" ");
        }
        Console.WriteLine();
      }
      Console.WriteLine();
    }
  }
}
