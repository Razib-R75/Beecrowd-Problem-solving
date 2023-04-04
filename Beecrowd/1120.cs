using System;

class MainClass {
  public static void Main (string[] args) {
    string[] input = Console.ReadLine().Split();
    char d = char.Parse(input[0]);
    string n = input[1];

    while (d != '0' || n != "0") {
      n = n.Replace(d.ToString(), "");
      n = n.TrimStart('0');
      if (n == "") n = "0";
      Console.WriteLine(n);

      input = Console.ReadLine().Split();
      d = char.Parse(input[0]);
      n = input[1];
    }
  }
}