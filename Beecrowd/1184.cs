using System;

class MainClass {
  public static void Main (string[] args) {
    char op = char.Parse(Console.ReadLine());
    double[,] M = new double[12, 12];
    double sum = 0.0;

    for (int i = 0; i < 12; i++) {
      for (int j = 0; j < 12; j++) {
        M[i, j] = double.Parse(Console.ReadLine());
        if (j < i) {
          sum += M[i, j];
        }
      }
    }

    if (op == 'S') {
      Console.WriteLine(sum.ToString("F1"));
    } else {
      double avg = sum / 66.0;
      Console.WriteLine(avg.ToString("F1"));
    }
  }
}
