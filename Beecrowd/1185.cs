using System;

class MainClass {
  public static void Main (string[] args) {
    double[,] M = new double[12, 12];
    double sum = 0.0;
    char O = char.Parse(Console.ReadLine());
    for(int i = 0; i < 12; i++) {
      for(int j = 0; j < 12; j++) {
        M[i, j] = double.Parse(Console.ReadLine());
      }
    }
    for(int i = 0; i < 11; i++) {
      for(int j = 0; j < 11 - i; j++) {
        sum += M[i, j];
      }
    }
    if(O == 'S') {
      Console.WriteLine(sum.ToString("F1"));
    }
    else if(O == 'M') {
      Console.WriteLine((sum / 66.0).ToString("F1"));
    }
  }
}
