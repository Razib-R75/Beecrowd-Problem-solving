using System;

class MainClass {
  public static void Main (string[] args) {
    double s = 1;
    for (int i = 2; i <= 100; i++) {
      s += 1.0 / i;
    }
    Console.WriteLine(s.ToString("F2"));
  }
}
