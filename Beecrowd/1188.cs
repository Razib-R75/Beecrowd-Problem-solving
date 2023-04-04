using System;

class MainClass {
  public static void Main (string[] args) {
    double[,] M = new double[12, 12];
    double sum = 0.0;
    char[] O = new char[2];
    O[1] = '\0';
    int n = 11, o = 1, i, j;
    Console.ReadLine().CopyTo(0, O, 0, 1);
    for (i = 0; i < 12; i++) {
      for (j = 0; j < 12; j++) {
        M[i, j] = double.Parse(Console.ReadLine());
      }
    }
    for (i = 11; i > 6; i--) {
      for (j = o; j < n; j++) {
        sum += M[i, j];
      }
      n--;
      o++;
    }
    if (O[0] == 'S') {
      Console.WriteLine("{0:F1}", sum);
    } else {
      Console.WriteLine("{0:F1}", sum / 30.0);
    }
  }
}
