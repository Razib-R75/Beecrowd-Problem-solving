using System;

class MainClass {
  public static void Main (string[] args) {
    int n = int.Parse(Console.ReadLine());

    for (int i = 2; i <= n; i += 2) {
        Console.WriteLine(i + "^2 = " + (i * i));
    }
  }
}
