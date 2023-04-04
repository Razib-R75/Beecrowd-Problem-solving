using System;

class MainClass {
  public static void Main (string[] args) {
    int n, i, j, l, k = 0;

    n = int.Parse(Console.ReadLine());

    for (i = 0; i < n; i++) {
      j = int.Parse(Console.ReadLine());

      for (l = 1; l < j; l++) {
        if (j % l == 0) {
          k += l;
        }
      }

      if (k == j) {
        Console.WriteLine(j + " eh perfeito");
      } else {
        Console.WriteLine(j + " nao eh perfeito");
      }

      k = 0;
    }
  }
}
