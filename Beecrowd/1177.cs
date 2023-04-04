using System;

class MainClass {
  public static void Main (string[] args) {
    int T = int.Parse(Console.ReadLine());
    int[] N = new int[1000];
    int j = 0;
    for (int i = 0; i < 1000; i++) {
      N[i] = j;
      Console.WriteLine("N[{0}] = {1}", i, N[i]);
      j++;
      if (j == T) j = 0;
    }
  }
}
