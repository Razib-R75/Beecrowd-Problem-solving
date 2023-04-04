using System;

class MainClass {
  public static void Main (string[] args) {
    int t = int.Parse(Console.ReadLine());

    for (int i = 0; i < t; i++) {
      string[] input = Console.ReadLine().Split(' ');

      int pa = int.Parse(input[0]);
      int pb = int.Parse(input[1]);
      double g1 = double.Parse(input[2]);
      double g2 = double.Parse(input[3]);

      int years = 0;

      while (pa <= pb && years <= 100) {
        pa = (int) (pa + pa * (g1 / 100));
        pb = (int) (pb + pb * (g2 / 100));
        years++;
      }

      if (years > 100) {
        Console.WriteLine("Mais de 1 seculo.");
      } else {
        Console.WriteLine(years + " anos.");
      }
    }
  }
}

