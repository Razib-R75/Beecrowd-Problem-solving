using System;

class MainClass {
  public static void Main (string[] args) {
    double s = 1;
    for (double i = 3, j = 2; i <= 39; i += 2, j *= 2) {
        s += i / j;
    }
    Console.WriteLine(s.ToString("F2"));
  }
}
