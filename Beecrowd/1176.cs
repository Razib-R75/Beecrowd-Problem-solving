using System;

class MainClass {
  public static void Main (string[] args) {
    int t = int.Parse(Console.ReadLine());
    long[] fib = new long[61];
    fib[0] = 0;
    fib[1] = 1;
    for (int i = 2; i <= 60; i++) {
      fib[i] = fib[i-1] + fib[i-2];
    }
    for (int i = 0; i < t; i++) {
      int n = int.Parse(Console.ReadLine());
      Console.WriteLine("Fib({0}) = {1}", n, fib[n]);
    }
  }
}
