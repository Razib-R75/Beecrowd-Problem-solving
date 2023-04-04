using System;

class MainClass {
  public static void Main (string[] args) {
    string[] input = Console.ReadLine().Split();
    int a = int.Parse(input[0]);
    int b = int.Parse(input[1]);

    int q = a / b;
    int r = a % b;

    if (r < 0) {
      r += Math.Abs(b);
      q = (a - r) / b;
    }

    Console.WriteLine(q + " " + r);
  }
}