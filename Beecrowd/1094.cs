using System;
class MainClass {
  public static void Main (string[] args) {
    int n = int.Parse(Console.ReadLine());
    int total = 0;
    int coelhos = 0;
    int ratos = 0;
    int sapos = 0;

    for (int i = 1; i <= n; i++) {
      string[] linha = Console.ReadLine().Split(' ');
      int quantidade = int.Parse(linha[0]);
      char tipo = char.Parse(linha[1]);

      if (tipo == 'C') {
        coelhos += quantidade;
      } else if (tipo == 'R') {
        ratos += quantidade;
      } else {
        sapos += quantidade;
      }

      total += quantidade;
    }

    double percCoelhos = (double) coelhos / total * 100.0;
    double percRatos = (double) ratos / total * 100.0;
    double percSapos = (double) sapos / total * 100.0;

    Console.WriteLine($"Total: {total} cobaias");
    Console.WriteLine($"Total de coelhos: {coelhos}");
    Console.WriteLine($"Total de ratos: {ratos}");
    Console.WriteLine($"Total de sapos: {sapos}");
    Console.WriteLine($"Percentual de coelhos: {percCoelhos.ToString("F2")} %");
    Console.WriteLine($"Percentual de ratos: {percRatos.ToString("F2")} %");
    Console.WriteLine($"Percentual de sapos: {percSapos.ToString("F2")} %");
  }
}