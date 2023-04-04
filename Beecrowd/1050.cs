using System;

class MainClass {
        public static void Main (string[] args) {
        int ddd = int.Parse(Console.ReadLine());
     string city;

     switch (ddd) {
        case 61:
            city = "Brasilia";
            break;
        case 71:
            city = "Salvador";
            break;
        case 11:
            city = "Sao Paulo";
            break;
        case 21:
            city = "Rio de Janeiro";
            break;
        case 32:
            city = "Juiz de Fora";
            break;
        case 19:
            city = "Campinas";
            break;
        case 27:
            city = "Vitoria";
            break;
        case 31:
            city = "Belo Horizonte";
            break;
        default:
            city = "DDD nao cadastrado";
            break;
    }

    Console.WriteLine(city);
  }
}