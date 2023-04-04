using System;

class MainClass {
  public static void Main (string[] args) {
    string[] input = Console.ReadLine().Split(' ');
    int x = int.Parse(input[0]);
    int y = int.Parse(input[1]);

    for (int i = 1; i <= y; i++) {
      Console.Write(i);
      if (i % x == 0) {
        Console.WriteLine();
      }
      else {
        Console.Write(" ");
      }
    }
  }
}
