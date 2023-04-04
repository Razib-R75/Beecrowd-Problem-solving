using System;

class MainClass {
  public static void Main (string[] args) {
    int n = int.Parse(Console.ReadLine());
    string[] input = Console.ReadLine().Split();
    int[] x = new int[n];

    for (int i = 0; i < n; i++) {
      x[i] = int.Parse(input[i]);
    }

    int min = x[0];
    int pos = 0;

    for (int i = 1; i < n; i++) {
      if (x[i] < min) {
        min = x[i];
        pos = i;
      }
    }

    Console.WriteLine("Menor valor: " + min);
    Console.WriteLine("Posicao: " + pos);
  }
}
