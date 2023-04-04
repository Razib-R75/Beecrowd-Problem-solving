using System;

class MainClass {
  public static void Main (string[] args) {
    float i = 0;
    float j = 1;

    while (i <= 2.2) {
      if ((i > 0 && i < 1) || (i > 1 && i < 2) || (i > 2.1 && i <= 2.2)) {
        Console.WriteLine($"I={i:F1} J={j + i:F1}");
        Console.WriteLine($"I={i:F1} J={j + 1 + i:F1}");
        Console.WriteLine($"I={i:F1} J={j + 2 + i:F1}");
      } else {
        Console.WriteLine($"I={(int)i} J={(int)j + (int)i}");
        Console.WriteLine($"I={(int)i} J={(int)j + 1 + (int)i}");
        Console.WriteLine($"I={(int)i} J={(int)j + 2 + (int)i}");
      }

      i += 0.2f;
    }
  }
}