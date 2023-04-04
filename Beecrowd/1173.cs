using System;

class MainClass {
  public static void Main (string[] args) {
    int[] n = new int[10];
    n[0] = int.Parse(Console.ReadLine());

    for (int i = 1; i < 10; i++) {
      n[i] = n[i - 1] * 2;
    }

    for (int i = 0; i < 10; i++) {
      Console.WriteLine($"N[{i}] = {n[i]}");
    }
  }
}
