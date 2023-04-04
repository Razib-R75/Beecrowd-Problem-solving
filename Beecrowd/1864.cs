using System;

class MainClass {
  public static void Main (string[] args) {
    string message = "LIFE IS NOT A PROBLEM TO BE SOLVED";
    int n = int.Parse(Console.ReadLine());

    for (int i = 0; i < n; i++) {
      Console.Write(message[i]);
    }

    Console.WriteLine();
  }
}
