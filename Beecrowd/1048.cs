using System;

class MainClass {
  public static void Main (string[] args) {
    double salary = double.Parse(Console.ReadLine());

    double newSalary;
    double increase;
    int percent;

    if (salary <= 400.00) {
        percent = 15;
    } else if (salary <= 800.00) {
        percent = 12;
    } else if (salary <= 1200.00) {
        percent = 10;
    } else if (salary <= 2000.00) {
        percent = 7;
    } else {
        percent = 4;
    }

    increase = salary * percent / 100.0;
    newSalary = salary + increase;

    Console.WriteLine($"Novo salario: {newSalary:F2}");
    Console.WriteLine($"Reajuste ganho: {increase:F2}");
    Console.WriteLine($"Em percentual: {percent} %");
  }
}