using System;

class MainClass {
  public static void Main (string[] args) {
    int x = int.Parse(Console.ReadLine());
    int y = int.Parse(Console.ReadLine());

    if (x > y) {
      int temp = x;
      x = y;
      y = temp;
    }

    for (int i = x + 1; i < y; i++) {
      if (i % 5 == 2 || i % 5 == 3) {
        Console.WriteLine(i);
      }
    }
  }
}
