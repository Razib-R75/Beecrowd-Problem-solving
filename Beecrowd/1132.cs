using System;

class MainClass {
  public static void Main (string[] args) {
    int x = int.Parse(Console.ReadLine());
    int y = int.Parse(Console.ReadLine());
    int sum = 0;

    if (x > y) {
      int temp = x;
      x = y;
      y = temp;
    }

    for (int i = x; i <= y; i++) {
      if (i % 13 != 0) {
        sum += i;
      }
    }

    Console.WriteLine(sum);
  }
}
