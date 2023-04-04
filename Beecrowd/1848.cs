using System;

class MainClass {
  public static void Main (string[] args) {
    int count = 0;
    int sum = 0;

    while (count < 3) {
      string input = Console.ReadLine();
      if (input == "--*") {
        sum += 1;
      } else if (input == "-*-") {
        sum += 2;
      } else if (input == "-**") {
        sum += 3;
      } else if (input == "*--") {
        sum += 4;
      } else if (input == "*-*") {
        sum += 5;
      } else if (input == "**-") {
        sum += 6;
      } else if (input == "***") {
        sum += 7;
      } else if (input == "caw caw") {
        Console.WriteLine(sum);
        sum = 0;
        count++;
      }
    }
  }
}