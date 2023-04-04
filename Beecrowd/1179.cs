using System;

class MainClass {
  public static void Main (string[] args) {
    int[] par = new int[5];
    int[] impar = new int[5];
    int p = 0, i = 0, x;
    for (int j = 0; j < 15; j++) {
        x = int.Parse(Console.ReadLine());
        if (x % 2 == 0) {
            par[p] = x;
            p++;
            if (p == 5) {
                for (int k = 0; k < 5; k++) {
                    Console.WriteLine($"par[{k}] = {par[k]}");
                    par[k] = 0;
                }
                p = 0;
            }
        }
        else {
            impar[i] = x;
            i++;
            if (i == 5) {
                for (int k = 0; k < 5; k++) {
                    Console.WriteLine($"impar[{k}] = {impar[k]}");
                    impar[k] = 0;
                }
                i = 0;
            }
        }
    }
    for (int j = 0; j < 5; j++) {
        if (impar[j] != 0) {
            Console.WriteLine($"impar[{j}] = {impar[j]}");
        }
    }
    for (int j = 0; j < 5; j++) {
        if (par[j] != 0) {
            Console.WriteLine($"par[{j}] = {par[j]}");
        }
    }
  }
}
