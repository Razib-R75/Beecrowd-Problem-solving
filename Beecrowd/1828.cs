using System;

class MainClass {
  public static void Main (string[] args) {
    int t = int.Parse(Console.ReadLine());

    for (int i = 1; i <= t; i++) {
      string[] input = Console.ReadLine().Split();

      string sheldon = input[0];
      string raj = input[1];

      if (sheldon == raj) {
        Console.WriteLine($"Caso #{i}: De novo!");
      } else if (
        (sheldon == "tesoura" && raj == "papel") ||
        (sheldon == "papel" && raj == "pedra") ||
        (sheldon == "pedra" && raj == "lagarto") ||
        (sheldon == "lagarto" && raj == "Spock") ||
        (sheldon == "Spock" && raj == "tesoura") ||
        (sheldon == "tesoura" && raj == "lagarto") ||
        (sheldon == "lagarto" && raj == "papel") ||
        (sheldon == "papel" && raj == "Spock") ||
        (sheldon == "Spock" && raj == "pedra") ||
        (sheldon == "pedra" && raj == "tesoura")
      ) {
        Console.WriteLine($"Caso #{i}: Bazinga!");
      } else {
        Console.WriteLine($"Caso #{i}: Raj trapaceou!");
      }
    }
  }
}