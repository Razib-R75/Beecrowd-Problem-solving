using System;

class MainClass {
  public static void Main (string[] args) {
    int n = int.Parse(Console.ReadLine());
    int count = 1;

    for (int i = 0; i < n; i++) {
      Console.WriteLine(count + " " + (count + 1) + " " + (count + 2) + " PUM");
      count += 4;
    }
  }
}
