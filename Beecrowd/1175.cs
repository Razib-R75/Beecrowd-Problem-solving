using System;

class MainClass {
  public static void Main (string[] args) {
    int[] N = new int[20];
    for (int i = 0; i < N.Length; i++) {
        N[i] = int.Parse(Console.ReadLine());
    }
    for (int i = 0; i < N.Length / 2; i++) {
        int temp = N[i];
        N[i] = N[N.Length - 1 - i];
        N[N.Length - 1 - i] = temp;
    }
    for (int i = 0; i < N.Length; i++) {
        Console.WriteLine($"N[{i}] = {N[i]}");
    }
  }
}
