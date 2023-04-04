using System;

class MainClass {
  public static void Main (string[] args) {
    double salary = double.Parse(Console.ReadLine());

    double tax;
    if (salary <= 2000.00) {
        tax = 0.0;
    } else if (salary <= 3000.00) {
        tax = (salary - 2000.00) * 0.08;
    } else if (salary <= 4500.00) {
        tax = (1000.00 * 0.08) + ((salary - 3000.00) * 0.18);
    } else {
        tax = (1000.00 * 0.08) + (1500.00 * 0.18) + ((salary - 4500.00) * 0.28);
    }

    if (tax == 0.0) {
        Console.WriteLine("Isento");
    } else {
        Console.WriteLine($"R$ {tax:F2}");
    }
  }
}
