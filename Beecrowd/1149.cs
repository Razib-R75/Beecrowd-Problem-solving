using System;

class MainClass {
  public static void Main (string[] args) {
    string[] input = Console.ReadLine().Split();
    int a = int.Parse(input[0]);
    int b = int.Parse(input[1]);

    int sum = (a + b) * (b - a + 1) / 2;
    Console.WriteLine(sum);
  }
}
