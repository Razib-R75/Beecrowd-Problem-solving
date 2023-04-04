using System;

class MainClass {
  public static int gcd(int a, int b) {
    if (b == 0)
      return a;
    else
      return gcd(b, a % b);
  }

  public static void Main (string[] args) {
    int N = int.Parse(Console.ReadLine());
    for (int i = 0; i < N; i++) {
      string[] tokens = Console.ReadLine().Split();
      int F1 = int.Parse(tokens[0]);
      int F2 = int.Parse(tokens[1]);
      int GCD = gcd(F1, F2);
      Console.WriteLine(GCD);
    }
  }
}
