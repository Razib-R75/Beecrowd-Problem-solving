using System;

class MainClass {
  public static void Main (string[] args) {
    int a, b;

    while (true) {
      a = int.Parse(Console.ReadLine());

      if (a == 0) {
        break;
      } else {
        for (b = 1; b < a; b++) {
          Console.Write(b + " ");
        }
      }

      Console.WriteLine(a);
    }
  }
}
