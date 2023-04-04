using System;

class MainClass {
  public static void Main (string[] args) {
    int count = 0;
    double sum = 0;

    for (int i = 1; i <= 6; i++) {
        double n = double.Parse(Console.ReadLine());
        if (n > 0) {
            count++;
            sum += n;
        }
    }

    double average = sum / count;

    Console.WriteLine($"{count} valores positivos");
    Console.WriteLine($"{average.ToString("F1")}");
  }
}
