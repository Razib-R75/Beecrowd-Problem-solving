using System;

class MainClass {
  public static void Main (string[] args) {
    int count = 0;
    for (int i = 1; i <= 5; i++) {
        int n = int.Parse(Console.ReadLine());
        if (n % 2 == 0) {
            count++;
        }
    }
    Console.WriteLine($"{count} valores pares");
  }
}