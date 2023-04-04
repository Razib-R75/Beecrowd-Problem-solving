using System;

class MainClass {
  public static void Main (string[] args) {
    while (true) {
      int n = int.Parse(Console.ReadLine());
      if (n == 0) {
        break;
      }
      for (int i = 1; i <= n; i++) {
        for (int j = 1; j <= n; j++) {
          int x = Math.Abs(i - j) + 1;
          if (j > 1) {
            Console.Write(" ");
          }
          Console.Write("{0,3}", x);
        }
        Console.WriteLine();
      }
      Console.WriteLine();
    }
  }
}
