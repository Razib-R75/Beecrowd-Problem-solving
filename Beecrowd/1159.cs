using System;

class MainClass {
  public static void Main (string[] args) {
    int i, x, sum;
    while (true) {
      sum = 0;
      x = int.Parse(Console.ReadLine());
      if (x == 0) break;
      if (x % 2 != 0) x++;
      for (i = 0; i < 5; i++) {
        sum += x;
        x += 2;
      }
      Console.WriteLine(sum);
    }
  }
}
