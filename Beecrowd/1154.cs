using System;

class Program {
  static void Main(string[] args) {
    int age, sum = 0, count = 0;
    
    while (true) {
      age = int.Parse(Console.ReadLine());

      if (age < 0) {
        break;
      }

      sum += age;
      count++;
    }

    double average = (double) sum / count;
    Console.WriteLine(average.ToString("F2"));
  }
}
