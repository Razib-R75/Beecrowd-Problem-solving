using System;

class MainClass {
  public static void Main (string[] args) {
    int n = int.Parse(Console.ReadLine());

    for (int i = 0; i < n; i++) {
      int x = int.Parse(Console.ReadLine());

      bool isPrime = true;

      for (int j = 2; j <= Math.Sqrt(x); j++) {
        if (x % j == 0) {
          isPrime = false;
          break;
        }
      }

      Console.WriteLine(isPrime ? $"{x} eh primo" : $"{x} nao eh primo");
    }
  }
}
