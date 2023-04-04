using System;

class MainClass {
  public static void Main (string[] args) {
    double a = 0.0;
    double[,] M = new double[12, 12];
    char[] T = new char[2];
    int C, x, y, z, p = 11;

    // Read input
    T = Console.ReadLine().ToCharArray();
    for (x = 0; x <= 11; x++) {
      for (y = 0; y <= 11; y++) {
        M[x, y] = double.Parse(Console.ReadLine());
      }
    }

    // Calculate sum
    for (z = 1; z <= 11; z++) {
      for (C = 11; C >= p; C--) {
        a += M[z, C];
      }
      p--;
    }

    // Output result
    if (T[0] == 'S') {
      Console.WriteLine(a.ToString("F1"));
    } else if (T[0] == 'M') {
      a = a / 66.0;
      Console.WriteLine(a.ToString("F1"));
    }
  }
}
