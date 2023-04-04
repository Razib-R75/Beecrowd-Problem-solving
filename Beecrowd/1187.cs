using System;

class MainClass {
  public static void Main (string[] args) {
    char operation = char.Parse(Console.ReadLine());
    double[,] matrix = new double[12, 12];
    double sum = 0;
    int count = 0;

    for (int i = 0; i < 12; i++) {
      for (int j = 0; j < 12; j++) {
        matrix[i, j] = double.Parse(Console.ReadLine());

        if (j > i && j < 12 - i - 1) {
          sum += matrix[i, j];
          count++;
        }
      }
    }

    if (operation == 'S') {
      Console.WriteLine(sum.ToString("F1"));
    } else if (operation == 'M') {
      double average = sum / count;
      Console.WriteLine(average.ToString("F1"));
    }
  }
}
