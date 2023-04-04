using System;

class MainClass {
  public static void Main (string[] args) {
    int alcohol = 0;
    int gasoline = 0;
    int diesel = 0;
    int code;

    do {
      code = int.Parse(Console.ReadLine());

      if (code == 1) {
        alcohol++;
      }
      else if (code == 2) {
        gasoline++;
      }
      else if (code == 3) {
        diesel++;
      }

    } while (code != 4);

    Console.WriteLine("MUITO OBRIGADO");
    Console.WriteLine("Alcool: " + alcohol);
    Console.WriteLine("Gasolina: " + gasoline);
    Console.WriteLine("Diesel: " + diesel);
  }
}


