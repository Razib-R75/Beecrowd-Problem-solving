using System;

class MainClass {
  public static void Main (string[] args) {
    int N = int.Parse(Console.ReadLine());

    for (int i = 0; i < N; i++) {
      string[] values = Console.ReadLine().Split();
      int X = int.Parse(values[0]);
      int Y = int.Parse(values[1]);

      int sum = 0;
      for (int j = X; j < X + Y * 2; j++) {
        if (j % 2 != 0) {
          sum += j;
        }
      }

      Console.WriteLine(sum);
    }
  }
}
